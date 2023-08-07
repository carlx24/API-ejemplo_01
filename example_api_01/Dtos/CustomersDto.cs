namespace example_api_01.Dtos
{
    public class CustomersDto
    {
        // public  se puede acceder de cualquier parte
        // private acceder solo de la class customers 
        // Dto es un objeto que pasa la informacion de una capa a otra dentro o fuera de la Api
        public long Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

    }
}
