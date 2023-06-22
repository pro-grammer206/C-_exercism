namespace Oop;
class Zoo{
    static List<Animals> animalsDB = new List<Animals>();
 public static List<Animals> addAnimal(Animals a){
        animalsDB.Add(a);
        return animalsDB;
 }
}