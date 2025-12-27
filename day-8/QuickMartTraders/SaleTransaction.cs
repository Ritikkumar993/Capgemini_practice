class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public decimal PurchaseAmount;
    public decimal SellingAmount;
    public string ProfitOrLossStatus;
    public decimal ProfitOrLossAmount;
    public decimal ProfitMarginPercent;

    public void Status()
    {
        if(SellingAmount>PurchaseAmount) ProfitOrLossStatus="PROFIT";
        if(SellingAmount<PurchaseAmount) ProfitOrLossStatus="LOSS";
        if(SellingAmount==PurchaseAmount) ProfitOrLossStatus="BREAK-EVEN"; 
    }
    public void Purchase_Amount()
    {
        if(SellingAmount>PurchaseAmount) ProfitOrLossAmount=Math.Round(SellingAmount-PurchaseAmount,2);
        if(SellingAmount<PurchaseAmount) ProfitOrLossAmount=Math.Round(PurchaseAmount-SellingAmount,2);
        if(SellingAmount==PurchaseAmount) ProfitOrLossAmount=0;
    }

    public void profitMarginPercent()
    {
        ProfitMarginPercent= Math.Round(ProfitOrLossAmount / PurchaseAmount * 100 ,2);
    }


}