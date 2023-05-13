using Exercise02;

List<Product> itemlist = new List<Product>
            {
           new Product { Id = 1,  Name = "Biscuit  " },
           new Product { Id = 2,  Name = "Chocolate" },
           new Product { Id = 3,  Name = "Butter   " },
           new Product { Id = 4,  Name = "Brade    " },
           new Product { Id = 5,  Name = "Honey    " }
            };
            

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvoiceNo=100, ProductId = 3,  Quantity = 800 },
           new Purchase { InvoiceNo=101, ProductId = 5,  Quantity = 650 },
           new Purchase { InvoiceNo=102, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=103, ProductId = 4,  Quantity = 700 },
           new Purchase { InvoiceNo=104, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=105, ProductId = 4,  Quantity = 650 },
           new Purchase { InvoiceNo=106, ProductId = 1,  Quantity = 458 }
            };

Console.Write("\nSample : Generate a Right Join between two data sets : ");
Console.Write("\n--------------------------------------------------\n");
Console.Write("Here is the Product List : ");
Console.Write("\n-------------------------\n");
foreach(var item in itemlist){
    Console.WriteLine(string.Format("Item Id: {0}, Title: {1}",item.Id , item.Name));
}

// to do

Console.Write("\nHere is the Purchase List : ");
Console.Write("\n--------------------------\n");
foreach(var purchase in purchlist){
    Console.WriteLine(string.Format("InvoiceNo: {0}, ProductId: {1}, Quantity: {2}", purchase.InvoiceNo, purchase.ProductId, purchase.Quantity));
}

// to do

Console.Write("\nHere is the list after joining  : \n\n");


// to do

Console.WriteLine("Product ID\t\tProduct Name\tPurchase Quantity");
Console.WriteLine("-------------------------------------------------------");
foreach(var purches in purchlist){
    foreach(var item in itemlist){
            if(item.Id == purches.ProductId){
                Console.WriteLine(string.Format("{0}\t{1}\t{2}\t",item.Id,item.Name,purches.Quantity));
                break;
            }
    }
}


// to do
Console.ReadLine();