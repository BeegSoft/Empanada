﻿using System;
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
        public Nuevo_usuario(string ds,string ds2,int id,int band)
        {
            InitializeComponent();
            this.ds2 = ds2;
            this.ds = ds;
            this.id = id;            
            this.band = band;
        }
        
        string ds,ds2;
        int band,id;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RESET()
        {
            txtclave.Clear();
            txtnombre.Clear();
            cbotipo.Text = "SELECCIONE TIPO";
            txtnombre.Focus();
        }                   

        private void btngrabar_Click(object sender, EventArgs e)
        {
            //cero para agregar
            if (band == 0)
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

                    OleDbConnection conexion = new OleDbConnection(ds2);
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
                        
                        RESET();
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
            //uno para modificar
            else if (band == 1)
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
                    OleDbConnection conexion = new OleDbConnection(ds2);
                    conexion.Open();                  

                    try
                    {
                        //ahora encriptamos                     
                        string var1 = Encriptado.Encriptar(txtclave.Text);


                        string insertar2 = "UPDATE USUARIOS SET nombre = @NOMBRE, clave = @CLAVE,tipo_usuario = @TIPO WHERE id =" + id;
                        OleDbCommand cmd3 = new OleDbCommand(insertar2, conexion);
                        cmd3.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                        cmd3.Parameters.AddWithValue("@CLAVE", var1);
                        cmd3.Parameters.AddWithValue("@TIPO", cbotipo.Text);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Usuario modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        RESET();
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

            #region Relogear la lista de usuarios
            IForm5 formInterface = this.Owner as IForm5;
            if (formInterface != null)
                formInterface.Cargar_usuarios();
            #endregion
        }

        private void Nuevo_usuario_Load(object sender, EventArgs e)
        {
            if (band == 1)
            {
                OleDbConnection conexion = new OleDbConnection(ds2);
                conexion.Open();

                //para obtener los datos

                //clave........................................................
                string select = "SELECT clave FROM USUARIOS WHERE id=" + id;
                OleDbCommand cmd6 = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string clv_des = reader.GetString(0);
                            string aux = Encriptado.DesEncriptar(clv_des);
                            txtclave.Text = aux;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //nombre...............................................................................
                string select2 = "SELECT nombre FROM USUARIOS WHERE id=" + id;
                OleDbCommand cmd62 = new OleDbCommand(select2, conexion);
                try
                {
                    OleDbDataReader reader = cmd62.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            txtnombre.Text = nombre;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //tipo..........................................................................
                string select3 = "SELECT tipo_usuario FROM USUARIOS WHERE id=" + id;
                OleDbCommand cmd63 = new OleDbCommand(select3, conexion);
                try
                {
                    OleDbDataReader reader = cmd63.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string tipo = reader.GetString(0);
                            cbotipo.Text = tipo;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();
                ///..........................................
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cero para agregar
            if (band == 0)
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

                    OleDbConnection conexion = new OleDbConnection(ds2);
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



                        RESET();
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
            //uno para modificar
            else if (band == 1)
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

                    OleDbConnection conexion = new OleDbConnection(ds2);
                    conexion.Open();
                    try
                    {
                        //ahora encriptamos                     
                        string var1 = Encriptado.Encriptar(txtclave.Text);


                        string insertar2 = "UPDATE USUARIOS SET nombre = @NOMBRE, clave = @CLAVE,tipo_usuario = @TIPO WHERE id =" + id;
                        OleDbCommand cmd3 = new OleDbCommand(insertar2, conexion);
                        cmd3.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                        cmd3.Parameters.AddWithValue("@CLAVE", var1);
                        cmd3.Parameters.AddWithValue("@TIPO", cbotipo.Text);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Usuario modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        RESET();
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
                this.Close();
            }
 
            IForm5 formInterface = this.Owner as IForm5;
            if (formInterface != null)
                formInterface.Cargar_usuarios();
            
        }
    }
}
