namespace InventryManagementSystem
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(ItemName.Text))
            Item item = new Item(ItemName.Text, QtyNum.Value, PriceNum.Value, ProfitUnit.Value);
            Console.WriteLine(item);
            items.Add(item);
            RefreshGrid();
            ClearField();
        }
        private void RefreshGrid()
        {
            ItemGrid.DataSource = string.Empty;
            ItemGrid.DataSource = items;
        }
        private void ClearField()
        {
            ItemName.Text = string.Empty;
            QtyNum.Value = 0;
            PriceNum.Value = 0;
            ProfitUnit.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemGrid.SelectedRows.Count == 1 && PriceNum.Value > 0)
            {
                Item SelectedItem = ItemGrid.SelectedRows[0].DataBoundItem as Item;
                string message = SelectedItem.ChangePrice(PriceNum.Value);

                RefreshGrid();
                ClearField();

                MessageBox.Show(message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QtyBtn_Click(object sender, EventArgs e)
        {
            if (ItemGrid.SelectedRows.Count == 1 && QtyNum.Value > 0)
            {
                Item SelectedItem = ItemGrid.SelectedRows[0].DataBoundItem as Item;
                string message = SelectedItem.ChangeQty(QtyNum.Value);

                RefreshGrid();
                ClearField();

                MessageBox.Show(message);
            }

        }

        private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
