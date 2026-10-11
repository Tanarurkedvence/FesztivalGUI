namespace FesztivalGUI
{
    public partial class Form1 : Form
    {
        List<Fesztival> fesztivals = new List<Fesztival>();
        static int id = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            textBox1.TextChanged += TextBox1_TextChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            DialogResult ngi = MessageBox.Show(
             caption: "Megerősítés",
             text: $"Valóban javaslatot tesz a(z) {ev.Text}. évi fesztivál adataira?",
             icon: MessageBoxIcon.Warning,
             buttons: MessageBoxButtons.YesNo);
            if (ngi == DialogResult.Yes)
            {
                using(StreamWriter i = new StreamWriter("../../../forras/javaslat.txt", true))
                {
                    i.WriteLine($"{DateTime.Now} Id:{id + 1} Adatok: {textBox2.Text} {textBox3.Text}");
                }
                Application.Exit();
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
             id = e.RowIndex;
             ev.Text = fesztivals[e.RowIndex].Alapitas.ToString();
             textBox2.Text = fesztivals[e.RowIndex].Latogato.ToString();
             textBox3.Text = fesztivals[e.RowIndex].Jegyar.ToString();

        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            var szuro = fesztivals.Where(x => x.Nev.ToLower().Contains(textBox1.Text.ToLower()) || x.Varos.ToLower().Contains(textBox1.Text.ToLower()));
            dataGridView1.Rows.Clear();
            foreach (var f in szuro) 
            {
                dataGridView1.Rows.Add(f.Id, f.Nev, f.Varos, f.Megye, f.Alapitas, f.Latogato, f.Jegyar);
            }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Read();
            Write();
        }

        private void Write()
        {
            foreach (var f in fesztivals)
            {
                dataGridView1.Rows.Add(f.Id, f.Nev, f.Varos, f.Megye, f.Alapitas, f.Latogato, f.Jegyar);
            }
            
        }

        private void Read()
        {
            using (StreamReader o = new StreamReader("../../../forras/fesztivalok.txt"))
            {
                while (!o.EndOfStream)
                {
                    string line = o.ReadLine();
                    fesztivals.Add(new Fesztival(line));
                }

            }
        }
    }
}
