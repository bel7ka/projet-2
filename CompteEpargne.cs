using System.Data.Common;
namespace tp2;
class CompteEpargne : Compte
{
    public double tauxInteret;
    public string dateOuverture;
    public static int Id = 1;
     
    public double GetTauxInteret() {return tauxInteret;}
    public void SetTauxInteret(double tauxinteret) {this.tauxInteret = tauxInteret;}

    public string GetdateOuverture() {return dateOuverture;}
    public void SetDateOuverture(string dateouverture) {this.dateOuverture = dateOuverture;}

}