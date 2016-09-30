﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.BulkInsert.Extensions;
using EntityFramework.MappingAPI;

namespace Inventario
{
    public partial class AddRecibo : Form
    {
        static int indexTar = 1;
        static int colums = 1;
        static int rows = 1;
        static double totalTarimas = 0;
        static double taraTotal = 0;
        static double pesoNeto = 0;
        static double pesoTarimasVacias = 0;
        MainInventario inventarioForm = new MainInventario();

        public AddRecibo()
        {
            InitializeComponent();
        }


        /*
          Private Custom Functions
        */
        private void getTotalPesos(string tb)
        {
            totalTarimas += double.Parse(tb);
            calculaPesoNeto();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            string value = "0";
            
            if (e.KeyCode == Keys.Enter)
            {
                addNewTarima();

                if (tb != null)
                {
                    value = tb.Text;
                    getTotalPesos(value);

                }

                txtBoxPesoTotal.Text = totalTarimas.ToString();
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
        }

        private void addNewTarima()
        {
            int ejeY = 30;
                       
            if(indexTar % 6 == 0 && indexTar <= 28)
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

            if(!String.IsNullOrEmpty(txbCantidadSacos2.Text))
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
                taraTotal += (int.Parse(txbCantSacos1.Text) * Double.Parse(txbTaraSacos1.Text));
            }
            if (!String.IsNullOrEmpty(txbCantidadSacos2.Text) &&
                !String.IsNullOrEmpty(txbTaraSacos2.Text))
            {
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
            if(!String.IsNullOrEmpty(txtBoxPesoTarimas.Text))
            {
                pesoTarimasVacias = Double.Parse(txtBoxPesoTarimas.Text);
            }

            pesoNeto = totalTarimas - taraTotal - pesoTarimasVacias;

            txtBoxPesoNeto.Text = pesoNeto.ToString();
        }

        /*
          Form events
        */
        private void MenuCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuHomeBtn_Click(object sender, EventArgs e)
        {
            MainInventario inventario = new MainInventario();
            inventario.Show();
            this.Hide();
        }

        private void AddRecibo_Load(object sender, EventArgs e)
        {
            using (inventarioEnt inventario = new inventarioEnt())
            {
                var recibos = (from o in inventario.reciboEntrada
                            select o.idreciboentrada).ToList();                

                if (recibos.Count > 0)
                {
                    if (recibos.Count <= 9)
                    {
                        txtBoxNumRec.Text = (recibos.Count + 1).ToString().PadLeft(4, '0');
                    }                                       
                }
                else
                {
                    txtBoxNumRec.Text = "0001";
                }
            }
        }

        private void cmbTipoSacos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbTipoSacos1.Text;
            double taraSaco = getTaraSelectedSaco(selectedValue);

            txbTaraSacos1.Text = taraSaco.ToString();
        }

        private void cmbTipoSacos2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = cmbTipoSacos2.Text;
            double taraSaco = getTaraSelectedSaco(selectedValue);

            txbTaraSacos2.Text = taraSaco.ToString();
        }

        private void txtBoxTarima1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addNewTarima();
                getTotalPesos(txtBoxTarima1.Text);
                txtBoxPesoTotal.Text = totalTarimas.ToString();
            }
        }

        private void linkAddSacos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkAddSacos.Visible = false;
            panelCantidadSacos2.Show();
        }
        
        private void txbTaraSacos1_TextChanged(object sender, EventArgs e)
        {
            getTaraSacos();
        }

        private void txbTaraSacos2_TextChanged(object sender, EventArgs e)
        {
            getTaraSacos();
        }        

        private void txbCantSacos1_TextChanged(object sender, EventArgs e)
        {
            getTotalSacos();
            getTaraSacos();
        }

        private void txbCantidadSacos2_TextChanged(object sender, EventArgs e)
        {
            getTotalSacos();
            getTaraSacos();
        }

        private void txtBoxTarima1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) &&
                ch != 8 &&
                ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBoxPesoTarimas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculaPesoNeto();
            }

        }

        private void btnSaveRecibo_Click(object sender, EventArgs e)
        {
            parseRecibo();
            parseTarimas();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInventarios();
        }

        private void btnCancelRecibo_Click(object sender, EventArgs e)
        {
            this.Close();
            inventarioForm.Show();
        }

        
        /*
          Database interaction fucntions
        */

        private void loadInventarios()
        {
            try
            {
                using (inventarioEnt inventario = new inventarioEnt())
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

        private int getTarimasId()
        {
            try
            {
                int tarimasID = 1;

                using (inventarioEnt inventario = new inventarioEnt())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var tarimas = (from tarima in inventario.entradaTarima
                                       select tarima).ToList();

                    if (tarimas.Count > 0)
                    {
                        tarimasID = tarimas.Count;
                    }                 

                }
                return tarimasID;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading inventarios: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }

        private void insertRecibo(reciboEntrada recibo)
        {
            try
            {
                using (inventarioEnt inventario = new inventarioEnt())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    if (recibo != null)
                    {
                        inventario.reciboEntrada.Add(recibo);
                        inventario.SaveChanges();
                        DialogResult addNew = MessageBox.Show("El recibo de entrada ha sido guardado correctamente. ¿Desea agregar otro recibo?", "Recibo Agregado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (addNew == DialogResult.OK)
                        {
                            AddRecibo newReciboForm = new AddRecibo();
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
                MessageBox.Show("Error trying to insert Recibo de entrada: " + e, "Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parseRecibo()
        {
            reciboEntrada recibo = new reciboEntrada();

            if (!String.IsNullOrEmpty(txtBoxNumRec.Text) &&
                !String.IsNullOrEmpty(cmbInventario.Text) &&
                !String.IsNullOrEmpty(dateTimeFecha.Text) &&
                !String.IsNullOrEmpty(txtBoxCalidad.Text) &&
                !String.IsNullOrEmpty(cmbCliente.Text) &&
                !String.IsNullOrEmpty(txtBoxPesoNeto.Text))
            {
                // If not required fields are empty
                recibo.idreciboentrada = int.Parse(txtBoxNumRec.Text);
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
                recibo.ubicacion = int.Parse(txtBoxUbicacion.Text);
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
            int idTar = getTarimasId();
            entradaTarima tarimas = new entradaTarima();

            foreach (Control txt in panelPesoTarimas.Controls)
            {
                if(txt is TextBox)
                {
                    if(!String.IsNullOrEmpty((txt as TextBox).Text))
                    {
                        tarimas.idtarimaentrada = idTar;
                        tarimas.idreciboentrada = int.Parse(txtBoxNumRec.Text);
                        tarimas.peso = double.Parse((txt as TextBox).Text);
                    }
                }
            }
        }
    }
}
