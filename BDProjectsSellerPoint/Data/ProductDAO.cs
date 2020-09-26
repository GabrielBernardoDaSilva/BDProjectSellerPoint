using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Data
{
    public static class ProductDAO
    {
         const string ConnectionString = "Server=DESKTOP-RD0K8GL\\SQLEXPRESS;Database=SellerPointDb;Integrated Security=True;";

        public static void AddProd(Product product)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = "INSERT INTO PROD VALUES (@PROD_CODE,@PROD_DESCRIPTION,@PROD_QUANTITY,@PROD_PRICE) ";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = sql;
                    command.Parameters.Add(new SqlParameter("@PROD_CODE", product.Cod));
                    command.Parameters.Add(new SqlParameter("@PROD_DESCRIPTION", product.Description));
                    command.Parameters.Add(new SqlParameter("@PROD_QUANTITY", product.Quantity));
                    command.Parameters.Add(new SqlParameter("@PROD_PRICE", product.Price));

                    command.ExecuteNonQuery();
                    command.Dispose();

                }



                con.Close();
            }
        }

        public static void DeleteProd(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = $"DELETE FROM PROD WHERE Id={id}";
                DAO.DbExecute(sql, con);
                con.Close();
            }
        }


        public static void UpdateProd(Product product)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = @"UPDATE PROD SET PROD_CODE = @CODE, PROD_DESCRIPTION = @DESCRIPTION,
                                PROD_QUANTITY= @QUANTITY, PROD_PRICE = @PRICE WHERe Id = @ID ";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = sql;
                    command.Parameters.Add(new SqlParameter("@CODE", product.Cod));
                    command.Parameters.Add(new SqlParameter("@DESCRIPTION", product.Description));
                    command.Parameters.Add(new SqlParameter("@QUANTITY", product.Quantity));
                    command.Parameters.Add(new SqlParameter("@PRICE", product.Price));
                    command.Parameters.Add(new SqlParameter("@ID",product.Id));

                    command.ExecuteNonQuery();
                    command.Dispose();

                }
                con.Close();
            }
        }

        public static List<Product> GetProducts()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = $"SELECT * FROM PROD";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Product> products = new List<Product>();
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                Cod = reader["PROD_CODE"].ToString(),
                                Description = reader["PROD_DESCRIPTION"].ToString(),
                                Quantity = int.Parse(reader["PROD_QUANTITY"].ToString()),
                                Price = double.Parse(reader["PROD_PRICE"].ToString())

                            };
                            products.Add(product);
                        }
                        return products;
                    }
                }
            }
        }

    }
}
