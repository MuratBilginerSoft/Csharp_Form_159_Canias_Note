﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Canias_Note_1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EKSCANIAS")]
	public partial class CANIASNOTEXENDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEKSADMIN(EKSADMIN instance);
    partial void UpdateEKSADMIN(EKSADMIN instance);
    partial void DeleteEKSADMIN(EKSADMIN instance);
    partial void InsertEKSTRANSACTION(EKSTRANSACTION instance);
    partial void UpdateEKSTRANSACTION(EKSTRANSACTION instance);
    partial void DeleteEKSTRANSACTION(EKSTRANSACTION instance);
    #endregion
		
		public CANIASNOTEXENDataContext() : 
				base(global::Canias_Note_1.Properties.Settings.Default.EKSCANIASConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CANIASNOTEXENDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CANIASNOTEXENDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CANIASNOTEXENDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CANIASNOTEXENDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EKSADMIN> EKSADMINs
		{
			get
			{
				return this.GetTable<EKSADMIN>();
			}
		}
		
		public System.Data.Linq.Table<EKSTRANSACTION> EKSTRANSACTIONs
		{
			get
			{
				return this.GetTable<EKSTRANSACTION>();
			}
		}
		
		public System.Data.Linq.Table<TRANSDIALOGINFO> TRANSDIALOGINFOs
		{
			get
			{
				return this.GetTable<TRANSDIALOGINFO>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LoginData")]
		public int SP_LoginData([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(15)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(15)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Count", DbType="NVarChar(5)")] ref string count)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password, count);
			count = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_TransactionInfo")]
		public ISingleResult<SP_TransactionInfoResult> SP_TransactionInfo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_TransactionInfoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_TransactionInfo2")]
		public ISingleResult<SP_TransactionInfo2Result> SP_TransactionInfo2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TransactionName", DbType="NVarChar(50)")] string transactionName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StartDialog", DbType="NVarChar(50)")] string startDialog, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modul", DbType="NVarChar(50)")] string modul, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CreatedBy", DbType="NVarChar(50)")] string createdBy, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangedBy", DbType="NVarChar(50)")] string changedBy)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), transactionName, startDialog, modul, createdBy, changedBy);
			return ((ISingleResult<SP_TransactionInfo2Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_UserPicture")]
		public int SP_UserPicture([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(15)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(15)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PersonelNo", DbType="NVarChar(8)")] ref string personelNo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(25)")] ref string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(25)")] ref string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Authority", DbType="NVarChar(1)")] ref string authority, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Picture", DbType="NVarChar(250)")] ref string picture)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password, personelNo, name, lastName, authority, picture);
			personelNo = ((string)(result.GetParameterValue(2)));
			name = ((string)(result.GetParameterValue(3)));
			lastName = ((string)(result.GetParameterValue(4)));
			authority = ((string)(result.GetParameterValue(5)));
			picture = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Transaction2Add")]
		public int SP_Transaction2Add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TransactionName", DbType="NVarChar(50)")] string transactionName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Aciklama", DbType="NVarChar(2000)")] string aciklama, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sebep", DbType="Int")] System.Nullable<int> sebep, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tarih", DbType="Date")] System.Nullable<System.DateTime> tarih, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Girisyapan", DbType="NVarChar(50)")] string girisyapan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), transactionName, aciklama, sebep, tarih, girisyapan);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Transaction2Select")]
		public ISingleResult<SP_Transaction2SelectResult> SP_Transaction2Select([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TransactionName", DbType="NVarChar(50)")] string transactionName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GirisYapan", DbType="NVarChar(50)")] string girisYapan)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), transactionName, girisYapan);
			return ((ISingleResult<SP_Transaction2SelectResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EKSADMIN")]
	public partial class EKSADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PERSONELNO;
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private string _NAME;
		
		private string _LASTNAME;
		
		private int _AUTHORITY;
		
		private System.DateTime _CREATEDATE;
		
		private string _PICTURE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPERSONELNOChanging(string value);
    partial void OnPERSONELNOChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnLASTNAMEChanging(string value);
    partial void OnLASTNAMEChanged();
    partial void OnAUTHORITYChanging(int value);
    partial void OnAUTHORITYChanged();
    partial void OnCREATEDATEChanging(System.DateTime value);
    partial void OnCREATEDATEChanged();
    partial void OnPICTUREChanging(string value);
    partial void OnPICTUREChanged();
    #endregion
		
		public EKSADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERSONELNO", DbType="NVarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PERSONELNO
		{
			get
			{
				return this._PERSONELNO;
			}
			set
			{
				if ((this._PERSONELNO != value))
				{
					this.OnPERSONELNOChanging(value);
					this.SendPropertyChanging();
					this._PERSONELNO = value;
					this.SendPropertyChanged("PERSONELNO");
					this.OnPERSONELNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LASTNAME", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string LASTNAME
		{
			get
			{
				return this._LASTNAME;
			}
			set
			{
				if ((this._LASTNAME != value))
				{
					this.OnLASTNAMEChanging(value);
					this.SendPropertyChanging();
					this._LASTNAME = value;
					this.SendPropertyChanged("LASTNAME");
					this.OnLASTNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AUTHORITY", DbType="Int NOT NULL")]
		public int AUTHORITY
		{
			get
			{
				return this._AUTHORITY;
			}
			set
			{
				if ((this._AUTHORITY != value))
				{
					this.OnAUTHORITYChanging(value);
					this.SendPropertyChanging();
					this._AUTHORITY = value;
					this.SendPropertyChanged("AUTHORITY");
					this.OnAUTHORITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDATE", DbType="Date NOT NULL")]
		public System.DateTime CREATEDATE
		{
			get
			{
				return this._CREATEDATE;
			}
			set
			{
				if ((this._CREATEDATE != value))
				{
					this.OnCREATEDATEChanging(value);
					this.SendPropertyChanging();
					this._CREATEDATE = value;
					this.SendPropertyChanged("CREATEDATE");
					this.OnCREATEDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PICTURE", DbType="NVarChar(250)")]
		public string PICTURE
		{
			get
			{
				return this._PICTURE;
			}
			set
			{
				if ((this._PICTURE != value))
				{
					this.OnPICTUREChanging(value);
					this.SendPropertyChanging();
					this._PICTURE = value;
					this.SendPropertyChanged("PICTURE");
					this.OnPICTUREChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EKSTRANSACTION")]
	public partial class EKSTRANSACTION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TRANSACTIONNAME;
		
		private string _STARTDIALOG;
		
		private string _MODUL;
		
		private string _CREATEDBY;
		
		private System.Nullable<System.DateTime> _CREATEDAT;
		
		private System.Nullable<int> _STATUS;
		
		private string _CHANGEDBY;
		
		private System.Nullable<System.DateTime> _CHANGEDAT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTRANSACTIONNAMEChanging(string value);
    partial void OnTRANSACTIONNAMEChanged();
    partial void OnSTARTDIALOGChanging(string value);
    partial void OnSTARTDIALOGChanged();
    partial void OnMODULChanging(string value);
    partial void OnMODULChanged();
    partial void OnCREATEDBYChanging(string value);
    partial void OnCREATEDBYChanged();
    partial void OnCREATEDATChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATEDATChanged();
    partial void OnSTATUSChanging(System.Nullable<int> value);
    partial void OnSTATUSChanged();
    partial void OnCHANGEDBYChanging(string value);
    partial void OnCHANGEDBYChanged();
    partial void OnCHANGEDATChanging(System.Nullable<System.DateTime> value);
    partial void OnCHANGEDATChanged();
    #endregion
		
		public EKSTRANSACTION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSACTIONNAME", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TRANSACTIONNAME
		{
			get
			{
				return this._TRANSACTIONNAME;
			}
			set
			{
				if ((this._TRANSACTIONNAME != value))
				{
					this.OnTRANSACTIONNAMEChanging(value);
					this.SendPropertyChanging();
					this._TRANSACTIONNAME = value;
					this.SendPropertyChanged("TRANSACTIONNAME");
					this.OnTRANSACTIONNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STARTDIALOG", DbType="NVarChar(50)")]
		public string STARTDIALOG
		{
			get
			{
				return this._STARTDIALOG;
			}
			set
			{
				if ((this._STARTDIALOG != value))
				{
					this.OnSTARTDIALOGChanging(value);
					this.SendPropertyChanging();
					this._STARTDIALOG = value;
					this.SendPropertyChanged("STARTDIALOG");
					this.OnSTARTDIALOGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODUL", DbType="NVarChar(50)")]
		public string MODUL
		{
			get
			{
				return this._MODUL;
			}
			set
			{
				if ((this._MODUL != value))
				{
					this.OnMODULChanging(value);
					this.SendPropertyChanging();
					this._MODUL = value;
					this.SendPropertyChanged("MODUL");
					this.OnMODULChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDBY", DbType="NVarChar(50)")]
		public string CREATEDBY
		{
			get
			{
				return this._CREATEDBY;
			}
			set
			{
				if ((this._CREATEDBY != value))
				{
					this.OnCREATEDBYChanging(value);
					this.SendPropertyChanging();
					this._CREATEDBY = value;
					this.SendPropertyChanged("CREATEDBY");
					this.OnCREATEDBYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATEDAT
		{
			get
			{
				return this._CREATEDAT;
			}
			set
			{
				if ((this._CREATEDAT != value))
				{
					this.OnCREATEDATChanging(value);
					this.SendPropertyChanging();
					this._CREATEDAT = value;
					this.SendPropertyChanged("CREATEDAT");
					this.OnCREATEDATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Int")]
		public System.Nullable<int> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this.OnSTATUSChanging(value);
					this.SendPropertyChanging();
					this._STATUS = value;
					this.SendPropertyChanged("STATUS");
					this.OnSTATUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDBY", DbType="NVarChar(50)")]
		public string CHANGEDBY
		{
			get
			{
				return this._CHANGEDBY;
			}
			set
			{
				if ((this._CHANGEDBY != value))
				{
					this.OnCHANGEDBYChanging(value);
					this.SendPropertyChanging();
					this._CHANGEDBY = value;
					this.SendPropertyChanged("CHANGEDBY");
					this.OnCHANGEDBYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CHANGEDAT
		{
			get
			{
				return this._CHANGEDAT;
			}
			set
			{
				if ((this._CHANGEDAT != value))
				{
					this.OnCHANGEDATChanging(value);
					this.SendPropertyChanging();
					this._CHANGEDAT = value;
					this.SendPropertyChanged("CHANGEDAT");
					this.OnCHANGEDATChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRANSDIALOGINFO")]
	public partial class TRANSDIALOGINFO
	{
		
		private string _TRANSACTIONNAME;
		
		private string _DIALOGNAME;
		
		private string _STATUS;
		
		private string _EXPLANATION;
		
		public TRANSDIALOGINFO()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSACTIONNAME", DbType="NVarChar(20)")]
		public string TRANSACTIONNAME
		{
			get
			{
				return this._TRANSACTIONNAME;
			}
			set
			{
				if ((this._TRANSACTIONNAME != value))
				{
					this._TRANSACTIONNAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIALOGNAME", DbType="NVarChar(50)")]
		public string DIALOGNAME
		{
			get
			{
				return this._DIALOGNAME;
			}
			set
			{
				if ((this._DIALOGNAME != value))
				{
					this._DIALOGNAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="NVarChar(250)")]
		public string STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this._STATUS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXPLANATION", DbType="NVarChar(250)")]
		public string EXPLANATION
		{
			get
			{
				return this._EXPLANATION;
			}
			set
			{
				if ((this._EXPLANATION != value))
				{
					this._EXPLANATION = value;
				}
			}
		}
	}
	
	public partial class SP_TransactionInfoResult
	{
		
		private string _TRANSACTIONNAME;
		
		private string _STARTDIALOG;
		
		private string _MODUL;
		
		private string _CREATEDBY;
		
		private System.Nullable<System.DateTime> _CREATEDAT;
		
		private System.Nullable<int> _STATUS;
		
		private string _CHANGEDBY;
		
		private System.Nullable<System.DateTime> _CHANGEDAT;
		
		public SP_TransactionInfoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSACTIONNAME", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TRANSACTIONNAME
		{
			get
			{
				return this._TRANSACTIONNAME;
			}
			set
			{
				if ((this._TRANSACTIONNAME != value))
				{
					this._TRANSACTIONNAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STARTDIALOG", DbType="NVarChar(50)")]
		public string STARTDIALOG
		{
			get
			{
				return this._STARTDIALOG;
			}
			set
			{
				if ((this._STARTDIALOG != value))
				{
					this._STARTDIALOG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODUL", DbType="NVarChar(50)")]
		public string MODUL
		{
			get
			{
				return this._MODUL;
			}
			set
			{
				if ((this._MODUL != value))
				{
					this._MODUL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDBY", DbType="NVarChar(50)")]
		public string CREATEDBY
		{
			get
			{
				return this._CREATEDBY;
			}
			set
			{
				if ((this._CREATEDBY != value))
				{
					this._CREATEDBY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATEDAT
		{
			get
			{
				return this._CREATEDAT;
			}
			set
			{
				if ((this._CREATEDAT != value))
				{
					this._CREATEDAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Int")]
		public System.Nullable<int> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this._STATUS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDBY", DbType="NVarChar(50)")]
		public string CHANGEDBY
		{
			get
			{
				return this._CHANGEDBY;
			}
			set
			{
				if ((this._CHANGEDBY != value))
				{
					this._CHANGEDBY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CHANGEDAT
		{
			get
			{
				return this._CHANGEDAT;
			}
			set
			{
				if ((this._CHANGEDAT != value))
				{
					this._CHANGEDAT = value;
				}
			}
		}
	}
	
	public partial class SP_TransactionInfo2Result
	{
		
		private string _TRANSACTIONNAME;
		
		private string _STARTDIALOG;
		
		private string _MODUL;
		
		private string _CREATEDBY;
		
		private System.Nullable<System.DateTime> _CREATEDAT;
		
		private System.Nullable<int> _STATUS;
		
		private string _CHANGEDBY;
		
		private System.Nullable<System.DateTime> _CHANGEDAT;
		
		public SP_TransactionInfo2Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSACTIONNAME", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TRANSACTIONNAME
		{
			get
			{
				return this._TRANSACTIONNAME;
			}
			set
			{
				if ((this._TRANSACTIONNAME != value))
				{
					this._TRANSACTIONNAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STARTDIALOG", DbType="NVarChar(50)")]
		public string STARTDIALOG
		{
			get
			{
				return this._STARTDIALOG;
			}
			set
			{
				if ((this._STARTDIALOG != value))
				{
					this._STARTDIALOG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODUL", DbType="NVarChar(50)")]
		public string MODUL
		{
			get
			{
				return this._MODUL;
			}
			set
			{
				if ((this._MODUL != value))
				{
					this._MODUL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDBY", DbType="NVarChar(50)")]
		public string CREATEDBY
		{
			get
			{
				return this._CREATEDBY;
			}
			set
			{
				if ((this._CREATEDBY != value))
				{
					this._CREATEDBY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATEDAT
		{
			get
			{
				return this._CREATEDAT;
			}
			set
			{
				if ((this._CREATEDAT != value))
				{
					this._CREATEDAT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Int")]
		public System.Nullable<int> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this._STATUS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDBY", DbType="NVarChar(50)")]
		public string CHANGEDBY
		{
			get
			{
				return this._CHANGEDBY;
			}
			set
			{
				if ((this._CHANGEDBY != value))
				{
					this._CHANGEDBY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHANGEDAT", DbType="DateTime")]
		public System.Nullable<System.DateTime> CHANGEDAT
		{
			get
			{
				return this._CHANGEDAT;
			}
			set
			{
				if ((this._CHANGEDAT != value))
				{
					this._CHANGEDAT = value;
				}
			}
		}
	}
	
	public partial class SP_Transaction2SelectResult
	{
		
		private string _TransactionName;
		
		private string _Açıklama;
		
		private System.Nullable<int> _Sebep;
		
		private System.Nullable<System.DateTime> _Tarih;
		
		private string _GirişYapan;
		
		public SP_Transaction2SelectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionName", DbType="NVarChar(50)")]
		public string TransactionName
		{
			get
			{
				return this._TransactionName;
			}
			set
			{
				if ((this._TransactionName != value))
				{
					this._TransactionName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Açıklama", DbType="NVarChar(2000)")]
		public string Açıklama
		{
			get
			{
				return this._Açıklama;
			}
			set
			{
				if ((this._Açıklama != value))
				{
					this._Açıklama = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sebep", DbType="Int")]
		public System.Nullable<int> Sebep
		{
			get
			{
				return this._Sebep;
			}
			set
			{
				if ((this._Sebep != value))
				{
					this._Sebep = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarih", DbType="Date")]
		public System.Nullable<System.DateTime> Tarih
		{
			get
			{
				return this._Tarih;
			}
			set
			{
				if ((this._Tarih != value))
				{
					this._Tarih = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GirişYapan", DbType="NVarChar(50)")]
		public string GirişYapan
		{
			get
			{
				return this._GirişYapan;
			}
			set
			{
				if ((this._GirişYapan != value))
				{
					this._GirişYapan = value;
				}
			}
		}
	}
}
#pragma warning restore 1591