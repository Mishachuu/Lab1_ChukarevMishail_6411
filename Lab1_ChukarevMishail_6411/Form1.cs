using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_ChukarevMishail_6411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            var probabilities = CalculateProbabilities(input);
            var codes = ShannonFano(probabilities);
            txtCode.Text = EncodeString(input, codes);
            txtProbabilities.Text = "";
            foreach (var pair in probabilities)
            {
                txtProbabilities.AppendText($"{pair.Key}: {pair.Value:P2}\r\n");
            }
            txtOriginalSize.Text = (input.Length * 8).ToString();
            txtEncodedSize.Text = txtCode.Text.Length.ToString();
            txtCompression.Text = (1.0 - (double)txtCode.Text.Length / (input.Length * 8)).ToString("P2");
        }

        private void BtnHuffmanEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO2.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            var frequencies = CalculateProbabilities(input);
            var huffmanCodes = Huffman(frequencies);
            txtCode2.Text = EncodeString(input, huffmanCodes);
            txtProbabilities2.Text = "";
            foreach (var pair in frequencies)
            {
                txtProbabilities2.AppendText($"{pair.Key}: {pair.Value:P2}\r\n");
            }
            txtOriginalSize2.Text = (input.Length * 8).ToString();
            txtEncodedSize2.Text = txtCode2.Text.Length.ToString();
            txtCompression2.Text = (1.0 - (double)txtCode2.Text.Length / (input.Length * 8)).ToString("P2");
        }

        private void BtnAlgEncode_Click(object sender, EventArgs e)
        {
            string input = txtFIO3.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку для кодирования!");
                return;
            }

            double encodedValue = Encode(input);
            txtCode3.Text = encodedValue.ToString();
            txtOriginalSize3.Text = (input.Length * 8).ToString();
            txtEncodedSize3.Text = txtCode3.Text.Length.ToString();
            txtCompression3.Text = (1.0 - (double)txtEncodedSize3.Text.Length / (input.Length * 8)).ToString("P2");
        }

        private Dictionary<char, double> CalculateProbabilities(string input)
        {
            Dictionary<char, double> probabilities = new Dictionary<char, double>();
            foreach (char c in input)
            {
                if (!probabilities.ContainsKey(c))
                {
                    probabilities[c] = 0;
                }
                probabilities[c]++;
            }

            int totalChars = input.Length;
            foreach (char c in probabilities.Keys.ToList())
            {
                probabilities[c] /= totalChars;
            }

            return probabilities.OrderByDescending(p => p.Value).ToDictionary(p => p.Key, p => p.Value);
        }

        private Dictionary<char, string> ShannonFano(Dictionary<char, double> probabilities)
        {
            Dictionary<char, string> codes = new Dictionary<char, string>();
            ShannonFanoRecursive(probabilities.Keys.ToList(), probabilities, codes, "");
            return codes;
        }

        private void ShannonFanoRecursive(List<char> symbols, Dictionary<char, double> probabilities, Dictionary<char, string> codes, string prefix)
        {
            if (symbols.Count == 1)
            {
                codes[symbols[0]] = prefix;
                return;
            }

            double total = symbols.Sum(s => probabilities[s]);
            double half = total / 2;
            double cumulative = 0;
            int splitIndex = 0;

            for (int i = 0; i < symbols.Count; i++)
            {
                cumulative += probabilities[symbols[i]];
                if (cumulative >= half)
                {
                    splitIndex = i;
                    break;
                }
            }

            List<char> left = symbols.Take(splitIndex + 1).ToList();
            List<char> right = symbols.Skip(splitIndex + 1).ToList();

            ShannonFanoRecursive(left, probabilities, codes, prefix + "0");
            ShannonFanoRecursive(right, probabilities, codes, prefix + "1");
        }

        private string EncodeString(string input, Dictionary<char, string> codes)
        {
            string encoded = "";
            foreach (char c in input)
            {
                encoded += codes[c];
            }
            return encoded;
        }

        private Dictionary<char, string> Huffman(Dictionary<char, double> frequencies)
        {
            var nodes = frequencies.Select(f => new HuffmanNode(f.Key, f.Value)).ToList();
            while (nodes.Count > 1)
            {
                var orderedNodes = nodes.OrderBy(n => n.Frequency).ToList();
                if (orderedNodes.Count >= 2)
                {
                    var left = orderedNodes[0];
                    var right = orderedNodes[1];
                    var parent = new HuffmanNode('\0', left.Frequency + right.Frequency) { Left = left, Right = right };
                    nodes.Remove(left);
                    nodes.Remove(right);
                    nodes.Add(parent);
                }
                nodes = nodes.OrderBy(n => n.Frequency).ToList();
            }

            var root = nodes.FirstOrDefault();
            var huffmanCodes = new Dictionary<char, string>();
            BuildHuffmanCodes(root, "", huffmanCodes);

            return huffmanCodes;
        }

        private void BuildHuffmanCodes(HuffmanNode node, string code, Dictionary<char, string> huffmanCodes)
        {
            if (node == null) return;

            if (node.Left == null && node.Right == null)
            {
                huffmanCodes[node.Symbol] = code;
            }

            BuildHuffmanCodes(node.Left, code + "0", huffmanCodes);
            BuildHuffmanCodes(node.Right, code + "1", huffmanCodes);
        }

        public double Encode(string input)
        {
            var probabilities = CalculateProbabilities(input);
            var intervals = BuildIntervals(probabilities);

            double low = 0.0, high = 1.0;
            foreach (char c in input)
            {
                var interval = intervals.First(i => i.Symbol == c);
                double range = high - low;
                high = low + range * interval.High;
                low += range * interval.Low;
            }
            return (low + high) / 2.0;
        }

        private List<SymbolInterval> BuildIntervals(Dictionary<char, double> probabilities)
        {
            double low = 0.0;
            var intervals = new List<SymbolInterval>();

            foreach (var kvp in probabilities)
            {
                double high = low + kvp.Value;
                intervals.Add(new SymbolInterval { Symbol = kvp.Key, Low = low, High = high });
                low = high;
            }

            return intervals;
        }

        public class HuffmanNode
        {
            public char Symbol { get; set; }
            public double Frequency { get; set; }
            public HuffmanNode Left { get; set; }
            public HuffmanNode Right { get; set; }

            public HuffmanNode(char symbol, double frequency)
            {
                Symbol = symbol;
                Frequency = frequency;
            }
        }

        public class SymbolInterval
        {
            public char Symbol { get; set; }
            public double Low { get; set; }
            public double High { get; set; }
        }
    }
}
