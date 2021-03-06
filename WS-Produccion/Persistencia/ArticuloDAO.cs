﻿using System;
using System.Data.SqlClient;

namespace WS_Produccion.Persistencia
{
    public class ArticuloDao
    {
        private string cadenaConexion = "Data Source=(local);Initial Catalog=BD_Proyectos;Integrated Security=SSPI";

        public Articulo Modificar(Articulo articuloAmodificar)
        {

            Articulo articuloModificado = null;
            string sql = "UPDATE Articulo SET Descripcion=@Descripcion, TipoExistencia=@TipoExistencia, StockActual=@StockActual,Activo=@Activo,IdFormulaProduccion=@IdFormulaProduccion  WHERE id =@Id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", articuloAmodificar.Id));
                    comando.Parameters.Add(new SqlParameter("@Descripcion", articuloAmodificar.Descripcion));
                    comando.Parameters.Add(new SqlParameter("@TipoExistencia", articuloAmodificar.TipoExistencia));
                    comando.Parameters.Add(new SqlParameter("@StockActual", articuloAmodificar.StockActual));
                    comando.Parameters.Add(new SqlParameter("@Activo", articuloAmodificar.Activo));
                    comando.Parameters.Add(new SqlParameter("@IdFormulaProduccion", articuloAmodificar.IdFormulaProduccion));


                    comando.ExecuteNonQuery();

                }

            }
            articuloModificado = Obtener(articuloAmodificar.Id);
            return articuloModificado;
        }

        public Articulo Obtener(Int32 id)
        {
            Articulo articuloEncontrado = null;
            string sql = "SELECT * FROM Articulo WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            articuloEncontrado = new Articulo()
                            {
                                Id = (Int32)resultado["Id"],
                                Descripcion = (string)resultado["Descripcion"],
                                TipoExistencia = (string)resultado["TipoExistencia"],
                                StockActual = (decimal)resultado["StockActual"],
                                Activo = (bool)resultado["Activo"],
                                IdFormulaProduccion = (Int32)resultado["IdFormulaProduccion"],

                            };
                        }
                    }

                }

            }

            return articuloEncontrado;
        }



    }
}