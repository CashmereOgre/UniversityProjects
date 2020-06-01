﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salaries
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SalariesDB")]
	public partial class SalariesLINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSalaries(Salaries instance);
    partial void UpdateSalaries(Salaries instance);
    partial void DeleteSalaries(Salaries instance);
    partial void InsertWorker(Worker instance);
    partial void UpdateWorker(Worker instance);
    partial void DeleteWorker(Worker instance);
    #endregion
		
		public SalariesLINQDataContext() : 
				base(global::Salaries.Properties.Settings.Default.SalariesDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesLINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesLINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Salaries> Salaries
		{
			get
			{
				return this.GetTable<Salaries>();
			}
		}
		
		public System.Data.Linq.Table<Worker> Worker
		{
			get
			{
				return this.GetTable<Worker>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salaries")]
	public partial class Salaries : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SalaryID;
		
		private int _WorkerID;
		
		private double _Base_sal;
		
		private double _Bonus;
		
		private int _YearsInWork;
		
		private double _ZUS;
		
		private double _HCDeducted;
		
		private double _HCAsessed;
		
		private bool _WorksInLiveCity;
		
		private double _TaxPercent;
		
		private bool _TaxRelief;
		
		private double _Tax;
		
		private double _Brutto;
		
		private double _Netto;
		
		private EntityRef<Worker> _Worker;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalaryIDChanging(int value);
    partial void OnSalaryIDChanged();
    partial void OnWorkerIDChanging(int value);
    partial void OnWorkerIDChanged();
    partial void OnBase_salChanging(double value);
    partial void OnBase_salChanged();
    partial void OnBonusChanging(double value);
    partial void OnBonusChanged();
    partial void OnYearsInWorkChanging(int value);
    partial void OnYearsInWorkChanged();
    partial void OnZUSChanging(double value);
    partial void OnZUSChanged();
    partial void OnHCDeductedChanging(double value);
    partial void OnHCDeductedChanged();
    partial void OnHCAsessedChanging(double value);
    partial void OnHCAsessedChanged();
    partial void OnWorksInLiveCityChanging(bool value);
    partial void OnWorksInLiveCityChanged();
    partial void OnTaxPercentChanging(double value);
    partial void OnTaxPercentChanged();
    partial void OnTaxReliefChanging(bool value);
    partial void OnTaxReliefChanged();
    partial void OnTaxChanging(double value);
    partial void OnTaxChanged();
    partial void OnBruttoChanging(double value);
    partial void OnBruttoChanged();
    partial void OnNettoChanging(double value);
    partial void OnNettoChanged();
    #endregion
		
		public Salaries()
		{
			this._Worker = default(EntityRef<Worker>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalaryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SalaryID
		{
			get
			{
				return this._SalaryID;
			}
			set
			{
				if ((this._SalaryID != value))
				{
					this.OnSalaryIDChanging(value);
					this.SendPropertyChanging();
					this._SalaryID = value;
					this.SendPropertyChanged("SalaryID");
					this.OnSalaryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkerID", DbType="Int NOT NULL")]
		public int WorkerID
		{
			get
			{
				return this._WorkerID;
			}
			set
			{
				if ((this._WorkerID != value))
				{
					if (this._Worker.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnWorkerIDChanging(value);
					this.SendPropertyChanging();
					this._WorkerID = value;
					this.SendPropertyChanged("WorkerID");
					this.OnWorkerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base_sal", DbType="Float NOT NULL")]
		public double Base_sal
		{
			get
			{
				return this._Base_sal;
			}
			set
			{
				if ((this._Base_sal != value))
				{
					this.OnBase_salChanging(value);
					this.SendPropertyChanging();
					this._Base_sal = value;
					this.SendPropertyChanged("Base_sal");
					this.OnBase_salChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Float NOT NULL")]
		public double Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearsInWork", DbType="Int NOT NULL")]
		public int YearsInWork
		{
			get
			{
				return this._YearsInWork;
			}
			set
			{
				if ((this._YearsInWork != value))
				{
					this.OnYearsInWorkChanging(value);
					this.SendPropertyChanging();
					this._YearsInWork = value;
					this.SendPropertyChanged("YearsInWork");
					this.OnYearsInWorkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZUS", DbType="Float NOT NULL")]
		public double ZUS
		{
			get
			{
				return this._ZUS;
			}
			set
			{
				if ((this._ZUS != value))
				{
					this.OnZUSChanging(value);
					this.SendPropertyChanging();
					this._ZUS = value;
					this.SendPropertyChanged("ZUS");
					this.OnZUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCDeducted", DbType="Float NOT NULL")]
		public double HCDeducted
		{
			get
			{
				return this._HCDeducted;
			}
			set
			{
				if ((this._HCDeducted != value))
				{
					this.OnHCDeductedChanging(value);
					this.SendPropertyChanging();
					this._HCDeducted = value;
					this.SendPropertyChanged("HCDeducted");
					this.OnHCDeductedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCAsessed", DbType="Float NOT NULL")]
		public double HCAsessed
		{
			get
			{
				return this._HCAsessed;
			}
			set
			{
				if ((this._HCAsessed != value))
				{
					this.OnHCAsessedChanging(value);
					this.SendPropertyChanging();
					this._HCAsessed = value;
					this.SendPropertyChanged("HCAsessed");
					this.OnHCAsessedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorksInLiveCity", DbType="Bit NOT NULL")]
		public bool WorksInLiveCity
		{
			get
			{
				return this._WorksInLiveCity;
			}
			set
			{
				if ((this._WorksInLiveCity != value))
				{
					this.OnWorksInLiveCityChanging(value);
					this.SendPropertyChanging();
					this._WorksInLiveCity = value;
					this.SendPropertyChanged("WorksInLiveCity");
					this.OnWorksInLiveCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxPercent", DbType="Float NOT NULL")]
		public double TaxPercent
		{
			get
			{
				return this._TaxPercent;
			}
			set
			{
				if ((this._TaxPercent != value))
				{
					this.OnTaxPercentChanging(value);
					this.SendPropertyChanging();
					this._TaxPercent = value;
					this.SendPropertyChanged("TaxPercent");
					this.OnTaxPercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxRelief", DbType="Bit NOT NULL")]
		public bool TaxRelief
		{
			get
			{
				return this._TaxRelief;
			}
			set
			{
				if ((this._TaxRelief != value))
				{
					this.OnTaxReliefChanging(value);
					this.SendPropertyChanging();
					this._TaxRelief = value;
					this.SendPropertyChanged("TaxRelief");
					this.OnTaxReliefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tax", DbType="Float NOT NULL")]
		public double Tax
		{
			get
			{
				return this._Tax;
			}
			set
			{
				if ((this._Tax != value))
				{
					this.OnTaxChanging(value);
					this.SendPropertyChanging();
					this._Tax = value;
					this.SendPropertyChanged("Tax");
					this.OnTaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brutto", DbType="Float NOT NULL")]
		public double Brutto
		{
			get
			{
				return this._Brutto;
			}
			set
			{
				if ((this._Brutto != value))
				{
					this.OnBruttoChanging(value);
					this.SendPropertyChanging();
					this._Brutto = value;
					this.SendPropertyChanged("Brutto");
					this.OnBruttoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Netto", DbType="Float NOT NULL")]
		public double Netto
		{
			get
			{
				return this._Netto;
			}
			set
			{
				if ((this._Netto != value))
				{
					this.OnNettoChanging(value);
					this.SendPropertyChanging();
					this._Netto = value;
					this.SendPropertyChanged("Netto");
					this.OnNettoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Worker_Salaries", Storage="_Worker", ThisKey="WorkerID", OtherKey="WorkerID", IsForeignKey=true)]
		public Worker Worker
		{
			get
			{
				return this._Worker.Entity;
			}
			set
			{
				Worker previousValue = this._Worker.Entity;
				if (((previousValue != value) 
							|| (this._Worker.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Worker.Entity = null;
						previousValue.Salaries.Remove(this);
					}
					this._Worker.Entity = value;
					if ((value != null))
					{
						value.Salaries.Add(this);
						this._WorkerID = value.WorkerID;
					}
					else
					{
						this._WorkerID = default(int);
					}
					this.SendPropertyChanged("Worker");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Worker")]
	public partial class Worker : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WorkerID;
		
		private string _Name;
		
		private string _Surname;
		
		private System.DateTime _DateOfBirth;
		
		private string _Gender;
		
		private string _Pesel;
		
		private EntitySet<Salaries> _Salaries;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWorkerIDChanging(int value);
    partial void OnWorkerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnDateOfBirthChanging(System.DateTime value);
    partial void OnDateOfBirthChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPeselChanging(string value);
    partial void OnPeselChanged();
    #endregion
		
		public Worker()
		{
			this._Salaries = new EntitySet<Salaries>(new Action<Salaries>(this.attach_Salaries), new Action<Salaries>(this.detach_Salaries));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WorkerID
		{
			get
			{
				return this._WorkerID;
			}
			set
			{
				if ((this._WorkerID != value))
				{
					this.OnWorkerIDChanging(value);
					this.SendPropertyChanging();
					this._WorkerID = value;
					this.SendPropertyChanged("WorkerID");
					this.OnWorkerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date NOT NULL")]
		public System.DateTime DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pesel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Pesel
		{
			get
			{
				return this._Pesel;
			}
			set
			{
				if ((this._Pesel != value))
				{
					this.OnPeselChanging(value);
					this.SendPropertyChanging();
					this._Pesel = value;
					this.SendPropertyChanged("Pesel");
					this.OnPeselChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Worker_Salaries", Storage="_Salaries", ThisKey="WorkerID", OtherKey="WorkerID")]
		public EntitySet<Salaries> Salaries
		{
			get
			{
				return this._Salaries;
			}
			set
			{
				this._Salaries.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Salaries(Salaries entity)
		{
			this.SendPropertyChanging();
			entity.Worker = this;
		}
		
		private void detach_Salaries(Salaries entity)
		{
			this.SendPropertyChanging();
			entity.Worker = null;
		}
	}
}
#pragma warning restore 1591
