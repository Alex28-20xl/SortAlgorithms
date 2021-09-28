using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Algorithm;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private List<SortedItem> items=new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);

                unsortedTexBox.AppendText(AddTextBox.Text+" ");                
            }

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                unsortedTexBox.Text = "";
                var rnd = new Random();
                for(int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100));                   
                    items.Add(item);

                    unsortedTexBox.AppendText(item.Value.ToString()+" ");
                }                
            }

            FillTextBox.Text = "";
        }       
        
        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            sortedTextBox.Text = "";
            
            
            var time = algorithm.Sort();

            for(int i = 0; i < algorithm.Items.Count; i++)
            {
                sortedTextBox.AppendText(algorithm.Items[i] + " ");
            }

            TimeLabel.Text = "Время: " + time.Milliseconds;
            CompareLabel.Text = "Колличество сравнений: " + algorithm.ComparisonCount;
            SwopLabel.Text = "Количество обменов: " + algorithm.SwopCount;
        }

        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);            
        }

        private void CocktailSortBtn_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }

        private void InsertSortBtn_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }        

        private void LsdRedixSortBtn_Click(object sender, EventArgs e)
        {
            var lsdRedix = new LsdRedixSort<SortedItem>(items);
            BtnClick(lsdRedix);
        }

        private void GnomeSortBtn_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            BtnClick(gnome);
        }

        private void ShellSortBtn_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new HeapSort<SortedItem>(items);
            BtnClick(heap);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new TreeSort<SortedItem>(items);
            BtnClick(tree);
        }

        private void MsdRedixSortBtn_Click(object sender, EventArgs e)
        {
            var msdRedix = new MsdRedixSort<SortedItem>(items);
            BtnClick(msdRedix);
        }

        private void MergeSortBtn_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            BtnClick(merge);
        }

        private void SelectionSortBtn_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnClick(selection);
        }

        private void QuickSortBtn_Click(object sender, EventArgs e)
        {
            var quick = new QuickSort<SortedItem>(items);
            BtnClick(quick);
        }
    }
}
