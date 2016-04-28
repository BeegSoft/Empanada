using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace empanada_2
{
    public partial class Nuevo_usuario : Form
    {
        public Nuevo_usuario(string ds,string texto,int band)
        {
            InitializeComponent();
            this.ds = ds;
            this.texto = texto;
            this.band = band;
        }
        string ds,texto;
        int band;

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (band==0)

            {
                if (this.cbotipo.Text == "SELECCIONAR")
                {
                    MessageBox.Show("Falta Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtnombre.Text == "")
                {
                    MessageBox.Show("Falta Usuario", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombre.Focus();
                }
                else if (txtclave.Text == "")
                {
                    MessageBox.Show("Falta Clave", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtclave.Focus();
                }
                else
                {
                    //ahora encriptamos 
                    string var1;
                    var1 = Encriptado.Encriptar(txtclave.Text);
                    //----------------------------------
                                       
                    OleDbConnection conexion = new OleDbConnection(ds);
                    conexion.Open();
                    try
                    {
                        string insertar = "INSERT INTO USUARIOS (nombre, clave, tipo_usuario) VALUES (@NOMBRE, @CLAVE, @TIPO)";
                        OleDbCommand cmd2 = new OleDbCommand(insertar, conexion);
                        cmd2.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                        cmd2.Parameters.AddWithValue("@CLAVE", var1);
                        cmd2.Parameters.AddWithValue("@TIPO", cbotipo.Text);

                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Usuario Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("Error de concurrencia:\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conexion.Close();
                }
            }
            else if(band==1)
            {                
                if (this.cbotipo.Text == "SELECCIONAR")
                {
                    MessageBox.Show("Falta Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtnombre.Text == "")
                {
                    MessageBox.Show("Falta Usuario", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombre.Focus();
                }
                else if (txtclave.Text == "")
                {
                    MessageBox.Show("Falta Clave", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtclave.Focus();
                }
                else
                {
                    
                    OleDbConnection conexion = new OleDbConnection(ds);
                    conexion.Open();
                    try
                    {
                        //ahora encriptamos                     
                        string var1 = Encriptado.Encriptar(txtclave.Text);
                        //----------------------------------
                        //realizar la conexion

                        string insertar2 = "UPDATE USUARIOS SET nombre = @NOMBRE WHERE nombre = '" + texto + "'";
                        OleDbCommand cmd3 = new OleDbCommand(insertar2, conexion);
                        cmd3.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                        cmd3.ExecuteNonQuery();

                        string insertar3 = "UPDATE USUARIOS SET clave = @CLAVE WHERE nombre = '" + texto + "'";
                        OleDbCommand cmd4 = new OleDbCommand(insertar3, conexion);
                        cmd4.Parameters.AddWithValue("@CLAVE", var1);
                        cmd4.ExecuteNonQuery();

                        string insertar4 = "UPDATE USUARIOS SET tipo_usuario = @TIPO WHERE nombre = '" + texto + "'";
                        OleDbCommand cmd5 = new OleDbCommand(insertar4, conexion);
                        cmd5.Parameters.AddWithValue("@TIPO", cbotipo.Text);
                        cmd5.ExecuteNonQuery();

                        MessageBox.Show("Usuario modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("Error de concurrencia:\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conexion.Close();
                }
            }
            this.Close();
        }
    }
}
