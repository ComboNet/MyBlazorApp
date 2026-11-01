using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace MyBlazorApp.Models
{
    [Table("products")]
    public class Product : BaseModel
    {
        // ต้องระบุ Primary Key ถึงแม้เราไม่ได้กรอกเองก็ตาม
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("code")]
        public string Code { get; set; } = string.Empty;

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("price")]
        public decimal Price { get; set; }
    }
}
