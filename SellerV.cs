using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POOTP_visualVendedor
{
    public partial class Seller : Form
    {
        private readonly string _connectionString = "server=localhost;user=root;password=;database=flyrp;";

        private DataTable tablaArticulos;
        private DataTable tablaPedido;

        public Seller()
        {
            InitializeComponent();
            this.Load += Seller_Load;
            Txt_Busqueda.TextChanged += Txt_Busqueda_TextChanged;
            Dgv_Articulos.CellDoubleClick += Dgv_Articulos_CellDoubleClick;
            Btn_Agregar.Click += Btn_Agregar_Click;
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            InicializarPedido();
            CargarArticulos();
        }

        private void InicializarPedido()
        {
            tablaPedido = new DataTable();
            tablaPedido.Columns.Add("id_producto", typeof(int));
            tablaPedido.Columns.Add("nombre", typeof(string));
            tablaPedido.Columns.Add("precio", typeof(decimal));
            tablaPedido.Columns.Add("cantidad", typeof(int));
            tablaPedido.Columns.Add("subtotal", typeof(decimal));

            Dgv_Pedido.AutoGenerateColumns = true;
            Dgv_Pedido.DataSource = tablaPedido;
        }

        private void CargarArticulos(string filtro = "")
        {
            string query = "SELECT id_producto, nombre, descripcion, categoria, precio, stock FROM productos";

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        tablaArticulos = new DataTable();
                        adapter.Fill(tablaArticulos);
                    }

                    Dgv_Articulos.AutoGenerateColumns = true;
                    Dgv_Articulos.DataSource = tablaArticulos;
                    Dgv_Articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos:\n" + ex.Message, "DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = Txt_Busqueda.Text.Trim();
            if (tablaArticulos != null)
            {
                DataView vistaFiltrada = tablaArticulos.DefaultView;
                vistaFiltrada.RowFilter = $"nombre LIKE '%{filtro}%' OR descripcion LIKE '%{filtro}%' OR categoria LIKE '%{filtro}%'";
            }
        }

        private void Dgv_Articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AgregarArticuloAPedido(e.RowIndex);
                ActualizarTotal();

            }

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Dgv_Articulos.CurrentRow != null)
            {
                AgregarArticuloAPedido(Dgv_Articulos.CurrentRow.Index);
            }
        }

        private void AgregarArticuloAPedido(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < Dgv_Articulos.Rows.Count)
            {
                DataRow fila = ((DataRowView)Dgv_Articulos.Rows[rowIndex].DataBoundItem).Row;

                int id = Convert.ToInt32(fila["id_producto"]);

                DataRow[] existentes = tablaPedido.Select($"id_producto = {id}");
                if (existentes.Length > 0)
                {
                    existentes[0]["cantidad"] = (int)existentes[0]["cantidad"] + 1;
                    existentes[0]["subtotal"] = (decimal)existentes[0]["precio"] * (int)existentes[0]["cantidad"];
                }
                else
                {
                    string nombre = fila["nombre"].ToString();
                    decimal precio = Convert.ToDecimal(fila["precio"]);

                    DataRow nuevaFila = tablaPedido.NewRow();
                    nuevaFila["id_producto"] = id;
                    nuevaFila["nombre"] = nombre;
                    nuevaFila["precio"] = precio;
                    nuevaFila["cantidad"] = 1;
                    nuevaFila["subtotal"] = precio;

                    tablaPedido.Rows.Add(nuevaFila);
                }
            }
            ActualizarTotal();

        }
        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataRow row in tablaPedido.Rows)
            {
                total += Convert.ToDecimal(row["subtotal"]);
            }

            Txt_Total.Text = total.ToString("0.00"); 
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Pedido.CurrentRow != null)
            {
                int rowIndex = Dgv_Pedido.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < tablaPedido.Rows.Count)
                {
                    tablaPedido.Rows.RemoveAt(rowIndex);
                }
                ActualizarTotal();

            }
        }
    }
}
