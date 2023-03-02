public class SavingsAccount : BankAccount {
    public SavingsAccount(string newCustomerName, double newBalance): base(newCustomerName, newBalance){
            balance += 200;
    }
}