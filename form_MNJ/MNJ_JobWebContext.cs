using Microsoft.EntityFrameworkCore;
namespace form_MNJ.Models;
namespace form_MNJ;

//Heredamos de la clase DbContext
public class MNJ_JobWebContext: DbContext
{
    //Model: Candidato
    //Colección: toda la coleccion de todos los datos dentro del modelo
   public DbSet<Candidato> Candidatos {get;set}
   //Constructor
    public MNJ_JobWebContext(DbContextOptions<MNJ_JobWebContext>options :base(options){}

   } 