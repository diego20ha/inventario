using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.BulkInsert.Extensions;
using EntityFramework.MappingAPI;

namespace Inventario
{
    public partial class AddSalida : Form
    {
        static int indexTar = 1;
        static int colums = 1;
        static int rows = 1;
        static double totalTarimas = 0;
        static double taraTotal = 0;
        static double pesoNeto = 0;
        static double pesoTarimasVacias = 0;
        static Dictionary<string, double> tarimasList = new Dictionary<string, double>();
        MainInventario inventarioForm = new MainInventario();
        formSaleDeSalida saleDeForm = new formSaleDeSalida();

        public AddSalida()
        {
            InitializeComponent();
        }

        /*
          Private Custom Functions
        */
        private void getTotalPesos()
        {
            totalTarimas = 0;

            foreach (var item in tarimasList)
            {
                totalTarimas += item.Value;
            }

            txtBoxPesoTotal.Text = totalTarimas.ToString();

            calculaPesoNeto();
        }

        private void updateTarimasList(string txbName, string value)
        {
            double finalVal = double.Parse(value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            if (tarimasList.ContainsKey(txbName))
            {
                tarimasList[txbName] = finalVal;
            }
            else
            {
                tarimasList.Add(txbName, finalVal);
            }

            getTotalPesos();
        }

        private void tb_leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Control ctxb = (Control)sender;
            String txbName = ctxb.Name;
            string value = "";

            if (tb != null && !String.IsNullOrEmpty(tb.Text))
            {
                value = tb.Text;
                updateTarimasList(txbName, value);
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            Control ctxb = (Control)sender;
            String txbName = ctxb.Name;
            string value = "";

            if (e.KeyCode == Keys.Enter)
            {
                addNewTarima();

                if (tb != null && !String.IsNullOrEmpty(tb.Text))
                {
                    value = tb.Text;
                    updateTarimasList(txbName, value);
                }
            }
        }

        private void tb_keyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) &&
                ch != 8 &&
                ch != 46)
            {
                e.Handled = true;
            }
        }

        private void addTxbKeyEvent(TextBox tb)
        {
            tb.KeyDown += new KeyEventHandler(tb_KeyDown);
            tb.KeyPress += new KeyPressEventHandler(tb_keyPress);
            tb.Leave += new EventHandler(tb_leave);
        }

        private void clearDynamicTarVars()
        {
            indexTar = 1;
            rows = 1;
        }

        private void addNewTarima()
        {
            int ejeY = 30;

            if (indexTar % 6 == 0 && indexTar <= 28)
            {
                rows = 1;
                colums++;
            }

            if (colums == 1)
            {
                Point tbPoint = new Point(20 + rows, ejeY * rows);
                Point lblPoint = new Point(0 + rows, ejeY * rows);

                TextBox tb = new TextBox();
                tb.Name = "txtBoxTarima" + indexTar;
                tb.Location = tbPoint;
                addTxbKeyEvent(tb);

                Label lbl = new Label();
                lbl.Text = (indexTar + 1) + ".";
                lbl.Location = lblPoint;

                panelPesoTarimasColumn1.Controls.Add(tb);
                panelPesoTarimasColumn1.Controls.Add(lbl);

                rows++;
            }
            else
            {
                if (colums == 2)
                {
                    Point tbPoint = new Point(20 + rows, ejeY * (rows - 1));
                    Point lblPoint = new Point(0 + rows, ejeY * (rows - 1));

                    TextBox tb = new TextBox();
                    tb.Name = "txtBoxTarima" + indexTar;
                    tb.Location = tbPoint;
                    addTxbKeyEvent(tb);

                    Label lbl = new Label();
                    lbl.Text = (indexTar + 1) + ".";
                    lbl.Location = lblPoint;

                    panelPesoTarimasColumn2.Controls.Add(tb);
                    panelPesoTarimasColumn2.Controls.Add(lbl);

                    rows++;
                }
                else
                {
                    if (colums == 3)
                    {
                        Point tbPoint = new Point(20 + rows, ejeY * (rows - 1));
                        Point lblPoint = new Point(0 + rows, ejeY * (rows - 1));

                        TextBox tb = new TextBox();
                        tb.Name = "txtBoxTarima" + indexTar;
                        tb.Location = tbPoint;
                        addTxbKeyEvent(tb);

                        Label lbl = new Label();
                        lbl.Text = (indexTar + 1) + ".";
                        lbl.Location = lblPoint;

                        panelPesoTarimasColumn3.Controls.Add(tb);
                        panelPesoTarimasColumn3.Controls.Add(lbl);

                        rows++;
                    }
                    else
                    {
                        if (colums == 4)
                        {
                            Point tbPoint = new Point(20 + rows, ejeY * (rows - 1));
                            Point lblPoint = new Point(0 + rows, ejeY * (rows - 1));

                            TextBox tb = new TextBox();
                            tb.Name = "txtBoxTarima" + indexTar;
                            tb.Location = tbPoint;
                            addTxbKeyEvent(tb);

                            Label lbl = new Label();
                            lbl.Text = (indexTar + 1) + ".";
                            lbl.Location = lblPoint;

                            panelPesoTarimasColumn4.Controls.Add(tb);
                            panelPesoTarimasColumn4.Controls.Add(lbl);

                            rows++;
                        }
                    }
                }
            }

            indexTar++;
        }

        private void getTotalSacos()
        {
            int totalSacos = 0;

            if (!String.IsNullOrEmpty(txbCantSacos1.Text))
            {
                totalSacos += int.Parse(txbCantSacos1.Text);
            }

            if (!String.IsNullOrEmpty(txbCantidadSacos2.Text))
            {
                totalSacos += int.Parse(txbCantidadSacos2.Text);
            }

            txtBoxTotalSacos.Text = totalSacos.ToString();
        }

        private void getTaraSacos()
        {
            if (!String.IsNullOrEmpty(txbCantSacos1.Text) &&
                !String.IsNullOrEmpty(txbTaraSacos1.Text))
            {
                taraTotal = 0;
                taraTotal += (int.Parse(txbCantSacos1.Text) * Double.Parse(txbTaraSacos1.Text));
            }
            if (!String.IsNullOrEmpty(txbCantidadSacos2.Text) &&
                !String.IsNullOrEmpty(txbTaraSacos2.Text))
            {
                taraTotal = 0;
                taraTotal += (int.Parse(txbCantidadSacos2.Text) * Double.Parse(txbTaraSacos2.Text));
            }

            txtboxPesoTotalSacos.Text = taraTotal.ToString();
            calculaPesoNeto();
        }

        private double getTaraSelectedSaco(string selectedValue)
        {
            double taraSaco = 0;

            switch (selectedValue)
            {
                case "Cabuya Nuevo":
                    taraSaco = 0.8;
                    break;
                case "Cabuya Segunda":
                    taraSaco = 0.8;
                    break;
                case "Yute Nuevo":
                    taraSaco = 0.773;
                    break;
                case "Yute Segunda":
                    taraSaco = 0.773;
                    break;
                case "Kennaff Nuevo":
                    taraSaco = 0.636;
                    break;
                case "Kennaff Segunda":
                    taraSaco = 0.636;
                    break;
                case "Plástico Nuevo":
                    taraSaco = 0.114;
                    break;
                case "Plástico Segunda":
                    taraSaco = 0.114;
                    break;
            }

            return taraSaco;
        }

        private void calculaPesoNeto()
        {
            if (!String.IsNullOrEmpty(txtBoxPesoTarimas.Text))
            {
                pesoTarimasVacias = Double.Parse(txtBoxPesoTarimas.Text);
            }
            else
            {
                pesoTarimasVacias = 0;
            }

            pesoNeto = totalTarimas - taraTotal - pesoTarimasVacias;

            txtBoxPesoNeto.Text = pesoNeto.ToString();
        }

        private void parseRecibo()
        {
            reciboSalida recibo = new reciboSalida();

            if (!String.IsNullOrEmpty(txtBoxNumRec.Text) &&
                !String.IsNullOrEmpty(cmbInventario.Text) &&
                !String.IsNullOrEmpty(dateTimeFecha.Text) &&
                !String.IsNullOrEmpty(txtBoxCalidad.Text) &&
                !String.IsNullOrEmpty(cmbCliente.Text) &&
                !String.IsNullOrEmpty(txtBoxPesoNeto.Text))
            {
                // If not required fields are empty
                recibo.idrecibosalida = int.Parse(txtBoxNumRec.Text);
                recibo.idinventario = int.Parse(cmbInventario.SelectedValue.ToString());
                recibo.fecha = dateTimeFecha.Value;
                recibo.calidad = txtBoxCalidad.Text;
                recibo.cliente = cmbCliente.Text;
                recibo.pesoneto = double.Parse(txtBoxPesoNeto.Text);
            }
            else
            {
                // if there is one or more required field on the form
                insertRecibo(null);
            }

            if (!String.IsNullOrEmpty(txtBoxTotalSacos.Text))
            {
                recibo.cantidadsacos = int.Parse(txtBoxTotalSacos.Text);
            }
            else
            {
                recibo.cantidadsacos = null;
            }

            if (!String.IsNullOrEmpty(txtboxPesoTotalSacos.Text))
            {
                recibo.pesototalsacos = double.Parse(txtboxPesoTotalSacos.Text);
            }
            else
            {
                recibo.pesototalsacos = null;
            }

            if (!String.IsNullOrEmpty(txtBoxContrato.Text))
            {
                recibo.contrato = txtBoxContrato.Text;
            }
            else
            {
                recibo.contrato = "";
            }

            if (!String.IsNullOrEmpty(txtBoxGuia.Text))
            {
                recibo.guia = txtBoxGuia.Text;
            }
            else
            {
                recibo.guia = "";
            }

            if (!String.IsNullOrEmpty(txtBoxPlaca.Text))
            {
                recibo.placa = txtBoxPlaca.Text;
            }
            else
            {
                recibo.placa = "";
            }

            if (!String.IsNullOrEmpty(txtBoxUbicacion.Text))
            {
                recibo.ubicacion = txtBoxUbicacion.Text;
            }
            else
            {
                recibo.ubicacion = null;
            }

            if (!String.IsNullOrEmpty(txtBoxPesoTarimas.Text))
            {
                recibo.pesotarimasvacias = double.Parse(txtBoxPesoTarimas.Text);
            }
            else
            {
                recibo.pesotarimasvacias = null;
            }

            if (!String.IsNullOrEmpty(txtBoxPesoTotal.Text))
            {
                recibo.pesobruto = double.Parse(txtBoxPesoTotal.Text);
            }
            else
            {
                recibo.pesobruto = null;
            }

            if (!String.IsNullOrEmpty(txtBoxObservaciones.Text))
            {
                recibo.observaciones = txtBoxObservaciones.Text;
            }
            else
            {
                recibo.observaciones = "";
            }

            insertRecibo(recibo);
        }

        private void parseTarimas()
        {
            try
            {
                int idTar = getTarimasSalidaId();
                salidaTarima tarimas = new salidaTarima();

                foreach (var item in tarimasList)
                {
                    tarimas.idtarimaSalida = idTar;
                    tarimas.idrecibosalida = int.Parse(txtBoxNumRec.Text);
                    tarimas.peso = item.Value;

                    insertTarima(tarimas);
                    idTar++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error parsing tarimas salida (función parse tarimas agrega salida): " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parseSacos()
        {
            try
            {
                int idSacos = getSacosSalidaId();
                reciboSalidaSacos sacos = new reciboSalidaSacos();
                if (!String.IsNullOrEmpty(txbCantSacos1.Text))
                {
                    sacos.idrecibosalidasacos = idSacos;
                    sacos.idrecibosalida = int.Parse(txtBoxNumRec.Text);
                    sacos.cantidad = int.Parse(txbCantSacos1.Text);
                    sacos.tipo = cmbTipoSacos1.Text;
                    sacos.tara = double.Parse(txbTaraSacos1.Text);

                    insertSaco(sacos);
                }
                if (!String.IsNullOrEmpty(txbCantidadSacos2.Text))
                {
                    reciboSalidaSacos sacos2 = new reciboSalidaSacos();
                    idSacos++;
                    sacos2.idrecibosalidasacos = idSacos;
                    sacos2.idrecibosalida = int.Parse(txtBoxNumRec.Text);
                    sacos2.cantidad = int.Parse(txbCantSacos1.Text);
                    sacos2.tipo = cmbTipoSacos1.Text;
                    sacos2.tara = double.Parse(txbTaraSacos1.Text);

                    insertSaco(sacos2);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error parsing sacos salida (función parse sacos): " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
          Database interaction functions
        */
        private void loadInventarios()
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var inventarios = (from inv in inventario.inventario
                                       select inv).ToList();

                    if (inventarios.Count > 0)
                    {
                        cmbInventario.ValueMember = "idinventario";
                        cmbInventario.DisplayMember = "nombreinventario";
                        cmbInventario.DataSource = inventarios;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading inventarios: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSaleDe()
        {
            try
            {
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading inventarios: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getSacosSalidaId()
        {
            try
            {
                int id = 1;
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var sacosList = (from sacos in inventario.reciboSalidaSacos
                                     select sacos).ToList();

                    if (sacosList.Count > 0)
                    {
                        id = sacosList.Count + 1;
                    }

                    return id;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting sacos id: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int getTarimasSalidaId()
        {
            try
            {
                int id = 0;
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var tarimas = (from tar in inventario.salidaTarima
                                   select tar).ToList();

                    if (tarimas.Count > 0)
                    {
                        id = tarimas.Count + 1;
                    }

                    return id;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getting tarimas id: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void insertRecibo(reciboSalida recibo)
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    if (recibo != null)
                    {
                        inventario.reciboSalida.Add(recibo);
                        inventario.SaveChanges();
                        parseTarimas();
                        parseSacos();

                        DialogResult addNew = MessageBox.Show("El recibo de salida ha sido guardado correctamente. ¿Desea agregar otro recibo?", "Recibo Agregado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (addNew == DialogResult.OK)
                        {
                            AddRecibo newReciboForm = new AddRecibo();
                            clearDynamicTarVars();
                            this.Close();
                            newReciboForm.Show();
                        }
                        else
                        {
                            this.Close();
                            inventarioForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese datos en todos los espacios requeridos.", "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error trying to insert Recibo de Salida: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertSaco(reciboSalidaSacos saco)
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    if (saco != null)
                    {
                        inventario.reciboSalidaSacos.Add(saco);
                        inventario.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error trying to insert sacos salida (salida): " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertTarima(salidaTarima tarima)
        {
            try
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    if (tarima != null)
                    {
                        inventario.salidaTarima.Add(tarima);
                        inventario.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error trying to insert tarimas salida (agrega salida): " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
            Form elements events 
         */
        private void AddSalida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clienteDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.clienteDataSet.cliente);
            using (inventarioEntities inventario = new inventarioEntities())
            {
                inventario.Configuration.AutoDetectChangesEnabled = false;

                var recibos = (from recibo in inventario.reciboSalida
                               select recibo.idrecibosalida).ToList();
                int recibosCount = recibos.Count;

                if (recibosCount > 0)
                {
                    txtBoxNumRec.Text = (recibos[recibosCount - 1] + 1).ToString().PadLeft(4, '0');
                }
                else
                {
                    txtBoxNumRec.Text = "0001";
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInventarios();
        }

        private void cmbInventario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int inventarioID = (int) cmbInventario.SelectedValue;
            saleDeForm.loadOrigines(inventarioID);
            saleDeForm.Show();
        }

        private void MenuCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
