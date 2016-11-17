﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class formSaleDeSalida : Form
    {
        public formSaleDeSalida()
        {
            InitializeComponent();
        }

        public void loadOrigines(int invID)
        {
            if (invID != 0)
            {
                using (inventarioEntities inventario = new inventarioEntities())
                {
                    inventario.Configuration.AutoDetectChangesEnabled = false;

                    var entradas = (from entradasOpt in inventario.reciboEntrada
                                    where entradasOpt.idinventario == invID
                                    select new { entradasOpt.idreciboentrada, entradasOpt.cliente, entradasOpt.calidad, entradasOpt.cantidadsacos, entradasOpt.pesoneto, entradasOpt.fecha }).ToList();

                    if (entradas.Count > 0)
                    {
                        cmbTipo.Items.Add("Entrada");

                        dgvOrigenes.DataSource = entradas;
                    }

                    var ordenID = (from ordenes in inventario.ordenTrabajo
                                   where ordenes.idinventario == invID
                                   select ordenes.idordentrabajo).ToList();
                    if (ordenID.Count > 0)
                    {
                        int selectedOrdenID = ordenID.Count;

                        var ordenesOrigen = (from ordenesOpt in inventario.ordenOrigen
                                             where ordenesOpt.idordentrabajo == selectedOrdenID
                                             select ordenesOpt).ToList();

                        if (ordenesOrigen.Count > 0)
                        {
                            /*
                            cmbTipo.Items.Add("Orden");
                            cmbSaleDe.ValueMember = "idordenorigin";
                            cmbSaleDe.DisplayMember = "tipoelemento, idordenorigin";
                            cmbSaleDe.DataSource = ordenes;
                           */
                        }
                    }                   
                }
            }
        }

        private void dgvOrigenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var elementId = dgvOrigenes.Rows[rowIndex].Cells["idreciboentrada"].Value;
        }
    }
}
