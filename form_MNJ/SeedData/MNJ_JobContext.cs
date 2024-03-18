using Microsoft.EntityFrameworkCore;
namespace form_MNJ.Models;
namespace form_MNJ;

public class MNJ_JobContext: DbContext
{
    //Model: Candidato
    //Colección: toda la coleccion de todos los datos dentro del modelo
   public DbSet<Candidato> Candidatos {get;set}
   //Constructor
    public MNJ_JobContext(DbContextOptions<MNJ_JobContext>options :base(options){}

   }