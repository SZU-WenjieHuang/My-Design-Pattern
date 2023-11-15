//-------------------------------------------------------------------------------------
//	StateExample1.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

//This real-world code demonstrates the State pattern which allows an Account to behave differently depending on its balance. 
//The difference in behavior is delegated to State objects called RedState, SilverState and GoldState. 
//These states represent overdrawn accounts, starter accounts, and accounts in good standing.

namespace StateExample1
{
    public class StateExample1 : MonoBehaviour
    {
        void Start()
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }
    }

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        protected Account account;
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        // Properties
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }


    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    class RedState : State
    {
        private double _serviceFee;

        // Constructor
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Debug.Log("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class SilverState : State
    {
        // Overloaded constructors

        public SilverState(State state) :
          this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    class GoldState : State
    {
        // Overloaded constructors
        public GoldState(State state)
          : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Account
    {
        private State _state;
        private string _owner;

        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        //to fix the private field "_owner' is assigned but its value is never used warning
        public string GetOwner()
        {
            return _owner;
        }

        // Properties
        public double Balance
        {
            get { return _state.Balance; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Debug.Log("Deposited " + amount + "---");
            Debug.Log(" Balance = " + this.Balance);
            Debug.Log(" Status = " + this.State.GetType().Name);
            Debug.Log("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Debug.Log("Deposited " + amount + "---");
            Debug.Log(" Balance = " + this.Balance);
            Debug.Log(" Status = " + this.State.GetType().Name + "\n");
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Debug.Log("Interest Paid --- ");
            Debug.Log(" Balance = " + this.Balance);
            Debug.Log(" Status = " + this.State.GetType().Name);

        }
    }
}

/*
 * 这个代码实现了一个账户状态的状态模式,主要包含以下几个要点:

抽象状态类State:定义了 deposit、withdraw、payInterest 等账户操作的公共接口。

具体状态类RedState、SilverState、GoldState:继承自State,实现了不同状态下的账户行为逻辑。

上下文类Account:维护了一个当前状态State对象,根据状态处理账户操作请求。

状态转移逻辑:每个具体状态类在操作后会检查状态转移条件,并设置Account的新状态。

运行流程:

创建账户,默认是SilverState状态。

进行存款、取款、计息等账户操作。

每个操作会调用状态对象的方法,不同状态有不同实现逻辑。

操作后检查状态转移条件,可能导致Account的当前状态被设置成新的状态。
*/