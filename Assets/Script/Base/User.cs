using System.Collections.Generic;

[System.Serializable]
public class User
{
    public string UserName;
    public long jewel;
    public long attributejewel;
    public List<Pickaxe> pickaxeList = new List<Pickaxe>();
    public List<Attribute> attributeList = new List<Attribute>();
    
}
