namespace SimpleRestfulAPIWithAspNetCore.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// horas já estão junto
        /// </summary>
        public DateTime Data { get; set; }       
    }
}