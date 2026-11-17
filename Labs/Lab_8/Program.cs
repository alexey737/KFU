using System.Reflection.Metadata;

public decimal CalculateOrderTotal(User user, List<OrderItems> items, bool applyDiscount)
{
    if (user == null || items == null)
        return 0;
    if (!user.IsActive)
        return 0;
    
    decimal total = 0;
    
    foreach (var item in items)
    {
        total += item.Price * item.Quantity;
    }
    
    if (applyDiscount)
        total *= 0.9m;
    
    return total;
}

//1
public enum Status
{
    Active = 1,
    Blocked = 2
}
public string GetStatus(Status status)
{
    return status switch
    {
        Status.Active => "active",
        Status.Blocked => "blocked",
        _ => "unknown"
    };
}

//2
public enum UserRole
{
    Admin,
    Editor,
    Viewer
}

public bool CanEdit(UserRole role)
{
    return role == UserRole.Admin || role == UserRole.Editor; 
}


//5
public decimal GetDiscount(User user)
{
    if (user != null && user.IsActive && user.OrdersCount > 5)
        return 0.1m;

    return 0m;
}

//6
public void CreateUser(User user)
{
    _db.Insert(user);
}

public void UpdateUser(User user)
{
    _db.Update(user);
}


//7
bool hasAccess = user switch
{
    { Role: "admin", IsBlocked: false, Subscription: "pro" } => true,
    { Role: "admin", IsBlocked: false, TrialDaysLeft: > 0 } => true,
    _ => false
};
if (hasAccess) ShowDashboard();

//8
public class BankAccount
{

    public decimal Balance { get; private set; }

    public void Withdraw(decimal amount)
    {
        
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }

        
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        
        Balance -= amount;
    }
}


//10
public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public interface IRestable
{
    void Sleep();
}


public class Human : IWorkable, IFeedable, IRestable
{
    public void Work() { }
    public void Eat() { }
    public void Sleep() { }
}


public class Robot : IWorkable
{
    public void Work() { }
}