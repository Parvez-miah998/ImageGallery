using System.Data.SqlClient;
using System.Net.Mime;
using System.Xml.Linq;

namespace ImageGallery.Models
{
    public class DAL
    {
        public Response register (Images image, SqlConnection connection)
        {
            Response response = new Response();
            SqlCommand cmd = new SqlCommand("sp_register", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", image.Name);
            cmd.Parameters.AddWithValue("@ImageData", image.ImageData);
            cmd.Parameters.AddWithValue("@ContentType", image.ContentType);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "OK";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage= "No";
            }

            return response;

        }
    }
}
