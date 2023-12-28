using Microsoft.VisualBasic;


public class Shop{

List<Products> products =new List<Products>();


public List<Products> PrintProductList(){

    return products;
}

public void AddProduct(Products products){
 
 this.products.Add(products);

}

public void RemoveProduct(int id){

for (int i = 0; i < products.Count; i++)
{
    if(id==products[i].Id){
        products.Remove(products[i]);

    }
}

}

}


