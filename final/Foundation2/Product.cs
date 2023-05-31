public class Product
{
   private string _name;
   private string _productID;
   private double _price;
   private int _quantity;

   public Product(string n, string p_id, double p, int q)
   {
        _name = n;
        _productID = p_id;
        _price = p;
        _quantity = q;
   }

   public double GetPriceProduct()
   {
        return _price * _quantity;
   }

   public string GetProductID()
   {
      return _productID;
   }

   public string GetName()
   {
      return _name;
   }

   public int GetQty(){
      return _quantity;
   }

   public double GetPrice()
   {
      return _price;
   }
}