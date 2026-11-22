namespace Calculer_degats;

/*
    CONSIGNES
    Dans votre jeu, chaque arme possède une puissance d'attaque. 
 */
class Program
{
    /*
     Vous devez créer une méthode CalculateWeaponDamage() qui reçoit deux paramètres :
    - weaponPower : la puissance de l'arme.
    - bonus : le bonus de dégâts du personnage.
    La méthode doit calculer les dégâts totaux et retourner le résultat.
     */
    static void CalculateWeaponDamage(int weaponPower, int bonus)
    {
        // 2. Récupérez le résultat dans une variable appelée degats.
        int dégats = weaponPower + bonus
    }

    /*
      Dans Main() :
    1. Appelez la méthode avec une arme de puissance 40 et un bonus de 15.
     */
    static void Main(string[] args)
    {
        CalculateWeaponDamage(40, 15)
         // 3. Affichez le nombre de dégâts infligés.
         Console.WriteLine("Dégats infligés : " + dégats)
    }
}