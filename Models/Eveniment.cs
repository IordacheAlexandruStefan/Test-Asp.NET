using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Eveniment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nume { get; set; }
    public int Pret_Bilet { get; set; }
    public string Data { get; set; }

    public async Task AddToDatabase(ApplicationDbContext context)
    {
        context.Evenimente.Add(this);
        await context.SaveChangesAsync();
    }
}