using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Participant
{
    public int Id { get; set; }
    public string Nume { get; set; }
    public string Email { get; set; }
    public string Parola { get; set; }
    public bool NewsLetter { get; set; }
    public bool Tip {  get; set; }

    public async Task AddToDatabase(ApplicationDbContext context)
    {
        context.Participanti.Add(this);
        await context.SaveChangesAsync();
    }
}