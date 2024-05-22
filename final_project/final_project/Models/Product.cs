namespace final_project.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string? Name { get; set; }        
        public string? Image { get; set; }
        public float Price { get; set; }  

        public int Order { get; set; } 
        public bool active { get; set; }  
    }
}
