namespace Task_5
{
    public partial class Form1 : Form
    {
        class Program
        {
            static void Main()
            {
                int[] array = { 5, 3, 8, 4, 2 };
                Console.WriteLine("Original Array: " + string.Join(", ", array));

                BubbleSort(array);

                Console.WriteLine("Sorted Array: " + string.Join(", ", array));
            }

            static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // Swap
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
