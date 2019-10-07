namespace WebApiJsonData.Models
{
    namespace SampleApp.Models
    {
        #region snippet1
        public class Opciones
        {
            public Opciones()
            {
                // Set default value.
                Option1 = "value1_from_ctor";
                ConnectionStrings = "una conexion a la db";

            }

            public string Option1 { get; set; }
            public int Option2 { get; set; } = 5;

            public string ConnectionStrings { get; set; }

            public long Puerto1 { get; set; } = 5;

            public Conexiones conexiones { get; set; }
        }
        #endregion

        public class Conexiones
        {

            public string suboption1 { get; set; }

            public string suboption2 { get; set; }
        }
    }
}
