namespace Nanogram_test
{
    public partial class Form1 : Form
    {
        private Button[,] gridButtons;
        private int[,] puzzleSolution;
        public Form1()
        {
            int size = new Random().Next(4, 4);

            gridButtons = new Button[size, size];
            puzzleSolution = new int[size, size];


            InitializeComponent();
            InitializeGrid(size, size);
            DisplayClues();
        }

        private void DisplayClues()
        {

        }
        private void InitializeGrid(int columns, int rows)
        {

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Button button = new()
                    {
                        Size = new Size(40, 40),
                        Tag = new Point(row, col),
                        FlatStyle = FlatStyle.Flat
                    };

                    button.Click += GridButton_Click;
                    gridPanel.Controls.Add(button, col, row);
                    gridButtons[row, col] = button;
                    var random = new Random();
                    puzzleSolution[row, col] = random.Next(2);
                }
            }

            Controls.Add(gridPanel);


        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Point position = (Point)button.Tag;

            if (button.BackColor == Color.Green || button.BackColor == Color.Red)
            {
                button.BackColor = Color.White;
            }
            else
            {
                if (puzzleSolution[position.X, position.Y] == 1)
                {
                    button.BackColor = Color.Green;
                }
                else
                {

                    button.BackColor = Color.Red;
                }
            }

        }

    }
}
