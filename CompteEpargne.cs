using System.Data.Common;

class CompteEpargne
{
    public double tauxInteret;
    public string dateOuverture;
    public static int Id = 1;
     
    public double GetTauxInteret() {return tauxInteret;}
    public string GetdateOuverture() {return dateOuverture;}
    public void SetTauxInteret(double tauxinteret) {this.tauxInteret = tauxInteret;}
    public void SetDateOuverture(string dateouverture) {this.dateOuverture = dateOuverture;}

}