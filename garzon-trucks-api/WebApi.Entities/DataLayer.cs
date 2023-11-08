
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
// using Microsoft.SqlServer.Types;
using System.Runtime.Serialization;

using System.ComponentModel;
using inercya.EntityLite;	
using inercya.EntityLite.Extensions;	

namespace WebApi.Entities
{
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="users")]
	public partial class User
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "users" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private String _loginName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="login_name", BaseColumnName ="login_name", BaseTableName = "users" )]		
		public String LoginName 
		{ 
		    get { return _loginName; } 
			set 
			{
			    _loginName = value;
			}
        }

		private String _userName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_name", BaseColumnName ="user_name", BaseTableName = "users" )]		
		public String UserName 
		{ 
		    get { return _userName; } 
			set 
			{
			    _userName = value;
			}
        }

		private String _userEmail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_email", BaseColumnName ="user_email", BaseTableName = "users" )]		
		public String UserEmail 
		{ 
		    get { return _userEmail; } 
			set 
			{
			    _userEmail = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "users" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "users" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "users" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "users" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "users" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private Boolean _isInternalUser;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_internal_user", BaseColumnName ="is_internal_user", BaseTableName = "users" )]		
		public Boolean IsInternalUser 
		{ 
		    get { return _isInternalUser; } 
			set 
			{
			    _isInternalUser = value;
			}
        }

		private Byte[] _userPasswordHash;
		[DataMember]
		[SqlField(DbType.Binary, 32, ColumnName ="user_password_hash" )]		
		public Byte[] UserPasswordHash 
		{ 
		    get { return _userPasswordHash; } 
			set 
			{
			    _userPasswordHash = value;
			}
        }

		private Byte[] _userPasswordSalt;
		[DataMember]
		[SqlField(DbType.Binary, 16, ColumnName ="user_password_salt" )]		
		public Byte[] UserPasswordSalt 
		{ 
		    get { return _userPasswordSalt; } 
			set 
			{
			    _userPasswordSalt = value;
			}
        }

		private DateTime? _userPasswordExpirationDate;
		[DataMember]
		[SqlField(DbType.Date, 3, AllowNull = true, ColumnName ="user_password_expiration_date" )]		
		public DateTime? UserPasswordExpirationDate 
		{ 
		    get { return _userPasswordExpirationDate; } 
			set 
			{
			    _userPasswordExpirationDate = value;
			}
        }

		private Int32? _userLoginAttemps;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="user_login_attemps" )]		
		public Int32? UserLoginAttemps 
		{ 
		    get { return _userLoginAttemps; } 
			set 
			{
			    _userLoginAttemps = value;
			}
        }

		private Boolean _assignedTaskEmailEnabled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="assigned_task_email_enabled" )]		
		public Boolean AssignedTaskEmailEnabled 
		{ 
		    get { return _assignedTaskEmailEnabled; } 
			set 
			{
			    _assignedTaskEmailEnabled = value;
			}
        }

		private Boolean _materialListEmailEnabled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="material_list_email_enabled" )]		
		public Boolean MaterialListEmailEnabled 
		{ 
		    get { return _materialListEmailEnabled; } 
			set 
			{
			    _materialListEmailEnabled = value;
			}
        }

		private Boolean _updatedEpisodeEmailEnabled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="updated_episode_email_enabled" )]		
		public Boolean UpdatedEpisodeEmailEnabled 
		{ 
		    get { return _updatedEpisodeEmailEnabled; } 
			set 
			{
			    _updatedEpisodeEmailEnabled = value;
			}
        }

		private Boolean _updatedBookingEmailEnabled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="updated_booking_email_enabled" )]		
		public Boolean UpdatedBookingEmailEnabled 
		{ 
		    get { return _updatedBookingEmailEnabled; } 
			set 
			{
			    _updatedBookingEmailEnabled = value;
			}
        }

		private Boolean _cancelBooking;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="cancel_booking" )]		
		public Boolean CancelBooking 
		{ 
		    get { return _cancelBooking; } 
			set 
			{
			    _cancelBooking = value;
			}
        }

		private Boolean _completeBooking;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="complete_booking" )]		
		public Boolean CompleteBooking 
		{ 
		    get { return _completeBooking; } 
			set 
			{
			    _completeBooking = value;
			}
        }

		private Boolean _freeTask;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="free_task" )]		
		public Boolean FreeTask 
		{ 
		    get { return _freeTask; } 
			set 
			{
			    _freeTask = value;
			}
        }

		private Boolean _generateDeliveryNote;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="generate_delivery_note" )]		
		public Boolean GenerateDeliveryNote 
		{ 
		    get { return _generateDeliveryNote; } 
			set 
			{
			    _generateDeliveryNote = value;
			}
        }

		private Boolean _generateOrder;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="generate_order" )]		
		public Boolean GenerateOrder 
		{ 
		    get { return _generateOrder; } 
			set 
			{
			    _generateOrder = value;
			}
        }

		private Boolean _includeHandSurgery;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_hand_surgery" )]		
		public Boolean IncludeHandSurgery 
		{ 
		    get { return _includeHandSurgery; } 
			set 
			{
			    _includeHandSurgery = value;
			}
        }

		private Boolean _includeMaterialRequested;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_material_requested" )]		
		public Boolean IncludeMaterialRequested 
		{ 
		    get { return _includeMaterialRequested; } 
			set 
			{
			    _includeMaterialRequested = value;
			}
        }

		private Boolean _includeMaterialUsed;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_material_used" )]		
		public Boolean IncludeMaterialUsed 
		{ 
		    get { return _includeMaterialUsed; } 
			set 
			{
			    _includeMaterialUsed = value;
			}
        }

		private Boolean _manageReposition;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="manage_reposition" )]		
		public Boolean ManageReposition 
		{ 
		    get { return _manageReposition; } 
			set 
			{
			    _manageReposition = value;
			}
        }

		private Boolean _postSurgeryDocumentation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="post_surgery_documentation" )]		
		public Boolean PostSurgeryDocumentation 
		{ 
		    get { return _postSurgeryDocumentation; } 
			set 
			{
			    _postSurgeryDocumentation = value;
			}
        }

		private Boolean _updateBooking;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="update_booking" )]		
		public Boolean UpdateBooking 
		{ 
		    get { return _updateBooking; } 
			set 
			{
			    _updateBooking = value;
			}
        }

		private Boolean _finishedTasksEmailEnabled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="finished_tasks_email_enabled" )]		
		public Boolean FinishedTasksEmailEnabled 
		{ 
		    get { return _finishedTasksEmailEnabled; } 
			set 
			{
			    _finishedTasksEmailEnabled = value;
			}
        }

		private Boolean _cancelBookingFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="cancel_booking_finished" )]		
		public Boolean CancelBookingFinished 
		{ 
		    get { return _cancelBookingFinished; } 
			set 
			{
			    _cancelBookingFinished = value;
			}
        }

		private Boolean _commentAdded;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="comment_added" )]		
		public Boolean CommentAdded 
		{ 
		    get { return _commentAdded; } 
			set 
			{
			    _commentAdded = value;
			}
        }

		private Boolean _completeBookingFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="complete_booking_finished" )]		
		public Boolean CompleteBookingFinished 
		{ 
		    get { return _completeBookingFinished; } 
			set 
			{
			    _completeBookingFinished = value;
			}
        }

		private Boolean _episodeCancelled;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="episode_cancelled" )]		
		public Boolean EpisodeCancelled 
		{ 
		    get { return _episodeCancelled; } 
			set 
			{
			    _episodeCancelled = value;
			}
        }

		private Boolean _freeTaskFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="free_task_finished" )]		
		public Boolean FreeTaskFinished 
		{ 
		    get { return _freeTaskFinished; } 
			set 
			{
			    _freeTaskFinished = value;
			}
        }

		private Boolean _generateDeliveryNoteFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="generate_delivery_note_finished" )]		
		public Boolean GenerateDeliveryNoteFinished 
		{ 
		    get { return _generateDeliveryNoteFinished; } 
			set 
			{
			    _generateDeliveryNoteFinished = value;
			}
        }

		private Boolean _generateOrderFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="generate_order_finished" )]		
		public Boolean GenerateOrderFinished 
		{ 
		    get { return _generateOrderFinished; } 
			set 
			{
			    _generateOrderFinished = value;
			}
        }

		private Boolean _includeHandSurgeryFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_hand_surgery_finished" )]		
		public Boolean IncludeHandSurgeryFinished 
		{ 
		    get { return _includeHandSurgeryFinished; } 
			set 
			{
			    _includeHandSurgeryFinished = value;
			}
        }

		private Boolean _includeMaterialRequestedFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_material_requested_finished" )]		
		public Boolean IncludeMaterialRequestedFinished 
		{ 
		    get { return _includeMaterialRequestedFinished; } 
			set 
			{
			    _includeMaterialRequestedFinished = value;
			}
        }

		private Boolean _includeMaterialUsedFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="include_material_used_finished" )]		
		public Boolean IncludeMaterialUsedFinished 
		{ 
		    get { return _includeMaterialUsedFinished; } 
			set 
			{
			    _includeMaterialUsedFinished = value;
			}
        }

		private Boolean _interventionDateChanged;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="intervention_date_changed" )]		
		public Boolean InterventionDateChanged 
		{ 
		    get { return _interventionDateChanged; } 
			set 
			{
			    _interventionDateChanged = value;
			}
        }

		private Boolean _manageRepositionFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="manage_reposition_finished" )]		
		public Boolean ManageRepositionFinished 
		{ 
		    get { return _manageRepositionFinished; } 
			set 
			{
			    _manageRepositionFinished = value;
			}
        }

		private Boolean _postSurgeryDocumentationFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="post_surgery_documentation_finished" )]		
		public Boolean PostSurgeryDocumentationFinished 
		{ 
		    get { return _postSurgeryDocumentationFinished; } 
			set 
			{
			    _postSurgeryDocumentationFinished = value;
			}
        }

		private Boolean _surgeryAuthorized;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="surgery_authorized" )]		
		public Boolean SurgeryAuthorized 
		{ 
		    get { return _surgeryAuthorized; } 
			set 
			{
			    _surgeryAuthorized = value;
			}
        }

		private Boolean _updateBookingFinished;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="update_booking_finished" )]		
		public Boolean UpdateBookingFinished 
		{ 
		    get { return _updateBookingFinished; } 
			set 
			{
			    _updateBookingFinished = value;
			}
        }

		private Boolean _deliveryTimeChanged;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="delivery_time_changed" )]		
		public Boolean DeliveryTimeChanged 
		{ 
		    get { return _deliveryTimeChanged; } 
			set 
			{
			    _deliveryTimeChanged = value;
			}
        }

		private Boolean _deliveryPlaceChanged;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="delivery_place_changed" )]		
		public Boolean DeliveryPlaceChanged 
		{ 
		    get { return _deliveryPlaceChanged; } 
			set 
			{
			    _deliveryPlaceChanged = value;
			}
        }

		private Boolean _deliveryDateChanged;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="delivery_date_changed" )]		
		public Boolean DeliveryDateChanged 
		{ 
		    get { return _deliveryDateChanged; } 
			set 
			{
			    _deliveryDateChanged = value;
			}
        }

		private Boolean _interventionLocationChanged;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="intervention_location_changed" )]		
		public Boolean InterventionLocationChanged 
		{ 
		    get { return _interventionLocationChanged; } 
			set 
			{
			    _interventionLocationChanged = value;
			}
        }

		private Boolean _manageSpecialAuthorization;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="manage_special_authorization" )]		
		public Boolean ManageSpecialAuthorization 
		{ 
		    get { return _manageSpecialAuthorization; } 
			set 
			{
			    _manageSpecialAuthorization = value;
			}
        }

		private String _wiCommentEmailsEnabled;
		[DataMember]
		[SqlField(DbType.AnsiString, 5, ColumnName ="wi_comment_emails_enabled" )]		
		public String WiCommentEmailsEnabled 
		{ 
		    get { return _wiCommentEmailsEnabled; } 
			set 
			{
			    _wiCommentEmailsEnabled = value;
			}
        }

		private Newtonsoft.Json.Linq.JToken _walkingImplants;
		[DataMember]
		[SqlField(DbType.AnsiString, 2147483647, ColumnName ="walking_implants_json" )]		
		public Newtonsoft.Json.Linq.JToken WalkingImplants 
		{ 
		    get { return _walkingImplants; } 
			set 
			{
			    _walkingImplants = value;
			}
        }

		private String _lastFirstOrderField;
		[DataMember]
		[SqlField(DbType.AnsiString, 100, ColumnName ="last_first_order_field" )]		
		public String LastFirstOrderField 
		{ 
		    get { return _lastFirstOrderField; } 
			set 
			{
			    _lastFirstOrderField = value;
			}
        }

		private String _lastSecondOrderField;
		[DataMember]
		[SqlField(DbType.AnsiString, 100, ColumnName ="last_second_order_field" )]		
		public String LastSecondOrderField 
		{ 
		    get { return _lastSecondOrderField; } 
			set 
			{
			    _lastSecondOrderField = value;
			}
        }

		private Boolean? _isDescending;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_descending" )]		
		public Boolean? IsDescending 
		{ 
		    get { return _isDescending; } 
			set 
			{
			    _isDescending = value;
			}
        }

		private Boolean? _isSecondDescending;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_second_descending" )]		
		public Boolean? IsSecondDescending 
		{ 
		    get { return _isSecondDescending; } 
			set 
			{
			    _isSecondDescending = value;
			}
        }

		private String _roleDescription;
		[DataMember]
		[SqlField(DbType.String, 2147483647, IsReadOnly = true, ColumnName ="role_description" )]		
		public String RoleDescription 
		{ 
		    get { return _roleDescription; } 
			set 
			{
			    _roleDescription = value;
			}
        }

		private String _wiUserName;
		[DataMember]
		[SqlField(DbType.String, 2147483647, IsReadOnly = true, ColumnName ="wi_user_name" )]		
		public String WiUserName 
		{ 
		    get { return _wiUserName; } 
			set 
			{
			    _wiUserName = value;
			}
        }

		private RoleId _roleId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="role_id" )]		
		public RoleId RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private Int32 _permissionId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="permission_id" )]		
		public Int32 PermissionId 
		{ 
		    get { return _permissionId; } 
			set 
			{
			    _permissionId = value;
			}
        }

		private String _permissionName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="permission_name" )]		
		public String PermissionName 
		{ 
		    get { return _permissionName; } 
			set 
			{
			    _permissionName = value;
			}
        }

		private String _roleName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name" )]		
		public String RoleName 
		{ 
		    get { return _roleName; } 
			set 
			{
			    _roleName = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [login_name], [user_name], [user_email], [is_active], [created_date], [created_by], [modified_date], [modified_by], [is_internal_user]";
		public const string BasicProjectionColumnList = "[user_id], [login_name], [user_name], [user_email], [is_active], [user_password_hash], [user_password_salt], [user_password_expiration_date], [user_login_attemps], [created_date], [created_by], [modified_date], [modified_by], [assigned_task_email_enabled], [material_list_email_enabled], [updated_episode_email_enabled], [updated_booking_email_enabled], [cancel_booking], [complete_booking], [free_task], [generate_delivery_note], [generate_order], [include_hand_surgery], [include_material_requested], [include_material_used], [manage_reposition], [post_surgery_documentation], [update_booking], [finished_tasks_email_enabled], [cancel_booking_finished], [comment_added], [complete_booking_finished], [episode_cancelled], [free_task_finished], [generate_delivery_note_finished], [generate_order_finished], [include_hand_surgery_finished], [include_material_requested_finished], [include_material_used_finished], [intervention_date_changed], [manage_reposition_finished], [post_surgery_documentation_finished], [surgery_authorized], [update_booking_finished], [delivery_time_changed], [delivery_place_changed], [delivery_date_changed], [intervention_location_changed], [manage_special_authorization], [wi_comment_emails_enabled], [walking_implants_json], [last_first_order_field], [last_second_order_field], [is_descending], [is_second_descending]";
		public const string ExtendedProjectionColumnList = "[user_name], [user_id], [is_active], [login_name], [user_email], [is_internal_user], [user_password_expiration_date], [created_date], [modified_date], [role_description], [wi_user_name]";
		public const string MinimalProjectionColumnList = "[user_id], [login_name], [user_name], [user_email], [is_active], [user_password_expiration_date], [user_login_attemps], [created_date], [created_by], [modified_date], [modified_by]";
		public const string PermissionBasicProjectionColumnList = "[user_id], [role_id], [permission_id], [permission_name], [role_name], [role_description]";

	}

	public partial class UserRepository : Repository<User> 
	{
		public UserRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public User Get(string projectionName, Int32 userId)
		{
			return ((IRepository<User>)this).Get(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public User Get(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<User>)this).Get(projectionName, userId, fetchMode);
		}

		public User Get(Projection projection, Int32 userId)
		{
			return ((IRepository<User>)this).Get(projection, userId, FetchMode.UseIdentityMap);
		}

		public User Get(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<User>)this).Get(projection, userId, fetchMode);
		}

		public User Get(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<User>)this).Get(projectionName, userId, fields);
		}

		public User Get(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<User>)this).Get(projection, userId, fields);
		}

		public bool Delete(Int32 userId)
		{
			var entity = new User { UserId = userId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<User> GetAsync(string projectionName, Int32 userId)
		{
			return ((IRepository<User>)this).GetAsync(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<User> GetAsync(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<User>)this).GetAsync(projectionName, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<User> GetAsync(Projection projection, Int32 userId)
		{
			return ((IRepository<User>)this).GetAsync(projection, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<User> GetAsync(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<User>)this).GetAsync(projection, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<User> GetAsync(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<User>)this).GetAsync(projectionName, userId, fields);
		}

		public System.Threading.Tasks.Task<User> GetAsync(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<User>)this).GetAsync(projection, userId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 userId)
		{
			var entity = new User { UserId = userId };
			return this.DeleteAsync(entity);
		}
			}
	[Obsolete("Use nameof instead")]
	public static partial class UserFields
	{
		public const string UserId = "UserId";
		public const string LoginName = "LoginName";
		public const string UserName = "UserName";
		public const string UserEmail = "UserEmail";
		public const string IsActive = "IsActive";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string IsInternalUser = "IsInternalUser";
		public const string UserPasswordHash = "UserPasswordHash";
		public const string UserPasswordSalt = "UserPasswordSalt";
		public const string UserPasswordExpirationDate = "UserPasswordExpirationDate";
		public const string UserLoginAttemps = "UserLoginAttemps";
		public const string AssignedTaskEmailEnabled = "AssignedTaskEmailEnabled";
		public const string MaterialListEmailEnabled = "MaterialListEmailEnabled";
		public const string UpdatedEpisodeEmailEnabled = "UpdatedEpisodeEmailEnabled";
		public const string UpdatedBookingEmailEnabled = "UpdatedBookingEmailEnabled";
		public const string CancelBooking = "CancelBooking";
		public const string CompleteBooking = "CompleteBooking";
		public const string FreeTask = "FreeTask";
		public const string GenerateDeliveryNote = "GenerateDeliveryNote";
		public const string GenerateOrder = "GenerateOrder";
		public const string IncludeHandSurgery = "IncludeHandSurgery";
		public const string IncludeMaterialRequested = "IncludeMaterialRequested";
		public const string IncludeMaterialUsed = "IncludeMaterialUsed";
		public const string ManageReposition = "ManageReposition";
		public const string PostSurgeryDocumentation = "PostSurgeryDocumentation";
		public const string UpdateBooking = "UpdateBooking";
		public const string FinishedTasksEmailEnabled = "FinishedTasksEmailEnabled";
		public const string CancelBookingFinished = "CancelBookingFinished";
		public const string CommentAdded = "CommentAdded";
		public const string CompleteBookingFinished = "CompleteBookingFinished";
		public const string EpisodeCancelled = "EpisodeCancelled";
		public const string FreeTaskFinished = "FreeTaskFinished";
		public const string GenerateDeliveryNoteFinished = "GenerateDeliveryNoteFinished";
		public const string GenerateOrderFinished = "GenerateOrderFinished";
		public const string IncludeHandSurgeryFinished = "IncludeHandSurgeryFinished";
		public const string IncludeMaterialRequestedFinished = "IncludeMaterialRequestedFinished";
		public const string IncludeMaterialUsedFinished = "IncludeMaterialUsedFinished";
		public const string InterventionDateChanged = "InterventionDateChanged";
		public const string ManageRepositionFinished = "ManageRepositionFinished";
		public const string PostSurgeryDocumentationFinished = "PostSurgeryDocumentationFinished";
		public const string SurgeryAuthorized = "SurgeryAuthorized";
		public const string UpdateBookingFinished = "UpdateBookingFinished";
		public const string DeliveryTimeChanged = "DeliveryTimeChanged";
		public const string DeliveryPlaceChanged = "DeliveryPlaceChanged";
		public const string DeliveryDateChanged = "DeliveryDateChanged";
		public const string InterventionLocationChanged = "InterventionLocationChanged";
		public const string ManageSpecialAuthorization = "ManageSpecialAuthorization";
		public const string WiCommentEmailsEnabled = "WiCommentEmailsEnabled";
		public const string WalkingImplants = "WalkingImplants";
		public const string LastFirstOrderField = "LastFirstOrderField";
		public const string LastSecondOrderField = "LastSecondOrderField";
		public const string IsDescending = "IsDescending";
		public const string IsSecondDescending = "IsSecondDescending";
		public const string RoleDescription = "RoleDescription";
		public const string WiUserName = "WiUserName";
		public const string RoleId = "RoleId";
		public const string PermissionId = "PermissionId";
		public const string PermissionName = "PermissionName";
		public const string RoleName = "RoleName";
	}

	public static partial class UserProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
		public const string Extended = "Extended";
		public const string Minimal = "Minimal";
		public const string PermissionBasic = "PermissionBasic";
	}
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="user_properties")]
	public partial class UserProperties
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_properties" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private Byte[] _userPasswordHash;
		[DataMember]
		[SqlField(DbType.Binary, 32, ColumnName ="user_password_hash", BaseColumnName ="user_password_hash", BaseTableName = "user_properties" )]		
		public Byte[] UserPasswordHash 
		{ 
		    get { return _userPasswordHash; } 
			set 
			{
			    _userPasswordHash = value;
			}
        }

		private Byte[] _userPasswordSalt;
		[DataMember]
		[SqlField(DbType.Binary, 16, ColumnName ="user_password_salt", BaseColumnName ="user_password_salt", BaseTableName = "user_properties" )]		
		public Byte[] UserPasswordSalt 
		{ 
		    get { return _userPasswordSalt; } 
			set 
			{
			    _userPasswordSalt = value;
			}
        }

		private DateTime? _userPasswordExpirationDate;
		[DataMember]
		[SqlField(DbType.Date, 3, AllowNull = true, ColumnName ="user_password_expiration_date", BaseColumnName ="user_password_expiration_date", BaseTableName = "user_properties" )]		
		public DateTime? UserPasswordExpirationDate 
		{ 
		    get { return _userPasswordExpirationDate; } 
			set 
			{
			    _userPasswordExpirationDate = value;
			}
        }

		private Int32? _userLoginAttemps;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="user_login_attemps", BaseColumnName ="user_login_attemps", BaseTableName = "user_properties" )]		
		public Int32? UserLoginAttemps 
		{ 
		    get { return _userLoginAttemps; } 
			set 
			{
			    _userLoginAttemps = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "user_properties" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "user_properties" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "user_properties" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "user_properties" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime? _changePasswordUrlExpirationDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="change_password_url_expiration_date", BaseColumnName ="change_password_url_expiration_date", BaseTableName = "user_properties" )]		
		public DateTime? ChangePasswordUrlExpirationDate 
		{ 
		    get { return _changePasswordUrlExpirationDate; } 
			set 
			{
			    _changePasswordUrlExpirationDate = value;
			}
        }

		private Byte[] _changePasswordUrlKey;
		[DataMember]
		[SqlField(DbType.Binary, 16, ColumnName ="change_password_url_key", BaseColumnName ="change_password_url_key", BaseTableName = "user_properties" )]		
		public Byte[] ChangePasswordUrlKey 
		{ 
		    get { return _changePasswordUrlKey; } 
			set 
			{
			    _changePasswordUrlKey = value;
			}
        }

		private String _loginName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="login_name" )]		
		public String LoginName 
		{ 
		    get { return _loginName; } 
			set 
			{
			    _loginName = value;
			}
        }

		private String _userName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_name" )]		
		public String UserName 
		{ 
		    get { return _userName; } 
			set 
			{
			    _userName = value;
			}
        }

		private String _userEmail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_email" )]		
		public String UserEmail 
		{ 
		    get { return _userEmail; } 
			set 
			{
			    _userEmail = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [user_password_hash], [user_password_salt], [user_password_expiration_date], [user_login_attemps], [created_date], [created_by], [modified_date], [modified_by], [change_password_url_expiration_date], [change_password_url_key]";
		public const string BasicProjectionColumnList = "[user_id], [login_name], [user_name], [user_email], [is_active], [user_password_hash], [user_password_salt], [user_password_expiration_date], [user_login_attemps], [created_date], [created_by], [modified_date], [modified_by], [change_password_url_expiration_date], [change_password_url_key]";

	}

	public partial class UserPropertiesRepository : Repository<UserProperties> 
	{
		public UserPropertiesRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public UserProperties Get(string projectionName, Int32 userId)
		{
			return ((IRepository<UserProperties>)this).Get(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public UserProperties Get(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserProperties>)this).Get(projectionName, userId, fetchMode);
		}

		public UserProperties Get(Projection projection, Int32 userId)
		{
			return ((IRepository<UserProperties>)this).Get(projection, userId, FetchMode.UseIdentityMap);
		}

		public UserProperties Get(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserProperties>)this).Get(projection, userId, fetchMode);
		}

		public UserProperties Get(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserProperties>)this).Get(projectionName, userId, fields);
		}

		public UserProperties Get(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserProperties>)this).Get(projection, userId, fields);
		}

		public bool Delete(Int32 userId)
		{
			var entity = new UserProperties { UserId = userId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<UserProperties> GetAsync(string projectionName, Int32 userId)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserProperties> GetAsync(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projectionName, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserProperties> GetAsync(Projection projection, Int32 userId)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projection, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserProperties> GetAsync(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projection, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserProperties> GetAsync(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projectionName, userId, fields);
		}

		public System.Threading.Tasks.Task<UserProperties> GetAsync(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserProperties>)this).GetAsync(projection, userId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 userId)
		{
			var entity = new UserProperties { UserId = userId };
			return this.DeleteAsync(entity);
		}
			}
	[Obsolete("Use nameof instead")]
	public static partial class UserPropertiesFields
	{
		public const string UserId = "UserId";
		public const string UserPasswordHash = "UserPasswordHash";
		public const string UserPasswordSalt = "UserPasswordSalt";
		public const string UserPasswordExpirationDate = "UserPasswordExpirationDate";
		public const string UserLoginAttemps = "UserLoginAttemps";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ChangePasswordUrlExpirationDate = "ChangePasswordUrlExpirationDate";
		public const string ChangePasswordUrlKey = "ChangePasswordUrlKey";
		public const string LoginName = "LoginName";
		public const string UserName = "UserName";
		public const string UserEmail = "UserEmail";
		public const string IsActive = "IsActive";
	}

	public static partial class UserPropertiesProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="user_password_history")]
	public partial class UserPasswordHistory
	{
		private Int32 _userPasswordHistoryId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_password_history_id", BaseColumnName ="user_password_history_id", BaseTableName = "user_password_history" )]		
		public Int32 UserPasswordHistoryId 
		{ 
		    get { return _userPasswordHistoryId; } 
			set 
			{
			    _userPasswordHistoryId = value;
			}
        }

		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_password_history" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private Byte[] _userPasswordHash;
		[DataMember]
		[SqlField(DbType.Binary, 32, ColumnName ="user_password_hash", BaseColumnName ="user_password_hash", BaseTableName = "user_password_history" )]		
		public Byte[] UserPasswordHash 
		{ 
		    get { return _userPasswordHash; } 
			set 
			{
			    _userPasswordHash = value;
			}
        }

		private Byte[] _userPasswordSalt;
		[DataMember]
		[SqlField(DbType.Binary, 16, ColumnName ="user_password_salt", BaseColumnName ="user_password_salt", BaseTableName = "user_password_history" )]		
		public Byte[] UserPasswordSalt 
		{ 
		    get { return _userPasswordSalt; } 
			set 
			{
			    _userPasswordSalt = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "user_password_history" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "user_password_history" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "user_password_history" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "user_password_history" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_password_history_id], [user_id], [user_password_hash], [user_password_salt], [created_date], [created_by], [modified_date], [modified_by]";

	}

	public partial class UserPasswordHistoryRepository : Repository<UserPasswordHistory> 
	{
		public UserPasswordHistoryRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public UserPasswordHistory Get(string projectionName, Int32 userPasswordHistoryId)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projectionName, userPasswordHistoryId, FetchMode.UseIdentityMap);
		}

		public UserPasswordHistory Get(string projectionName, Int32 userPasswordHistoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projectionName, userPasswordHistoryId, fetchMode);
		}

		public UserPasswordHistory Get(Projection projection, Int32 userPasswordHistoryId)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projection, userPasswordHistoryId, FetchMode.UseIdentityMap);
		}

		public UserPasswordHistory Get(Projection projection, Int32 userPasswordHistoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projection, userPasswordHistoryId, fetchMode);
		}

		public UserPasswordHistory Get(string projectionName, Int32 userPasswordHistoryId, params string[] fields)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projectionName, userPasswordHistoryId, fields);
		}

		public UserPasswordHistory Get(Projection projection, Int32 userPasswordHistoryId, params string[] fields)
		{
			return ((IRepository<UserPasswordHistory>)this).Get(projection, userPasswordHistoryId, fields);
		}

		public bool Delete(Int32 userPasswordHistoryId)
		{
			var entity = new UserPasswordHistory { UserPasswordHistoryId = userPasswordHistoryId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(string projectionName, Int32 userPasswordHistoryId)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projectionName, userPasswordHistoryId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(string projectionName, Int32 userPasswordHistoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projectionName, userPasswordHistoryId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(Projection projection, Int32 userPasswordHistoryId)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projection, userPasswordHistoryId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(Projection projection, Int32 userPasswordHistoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projection, userPasswordHistoryId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(string projectionName, Int32 userPasswordHistoryId, params string[] fields)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projectionName, userPasswordHistoryId, fields);
		}

		public System.Threading.Tasks.Task<UserPasswordHistory> GetAsync(Projection projection, Int32 userPasswordHistoryId, params string[] fields)
		{
			return ((IRepository<UserPasswordHistory>)this).GetAsync(projection, userPasswordHistoryId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 userPasswordHistoryId)
		{
			var entity = new UserPasswordHistory { UserPasswordHistoryId = userPasswordHistoryId };
			return this.DeleteAsync(entity);
		}
			}
	[Obsolete("Use nameof instead")]
	public static partial class UserPasswordHistoryFields
	{
		public const string UserPasswordHistoryId = "UserPasswordHistoryId";
		public const string UserId = "UserId";
		public const string UserPasswordHash = "UserPasswordHash";
		public const string UserPasswordSalt = "UserPasswordSalt";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
	}

	public static partial class UserPasswordHistoryProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="master_data")]
	public partial class MasterData
	{
		private Int32 _masterItemId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="master_item_id", BaseColumnName ="master_item_id", BaseTableName = "master_data" )]		
		public Int32 MasterItemId 
		{ 
		    get { return _masterItemId; } 
			set 
			{
			    _masterItemId = value;
			}
        }

		private Int32 _masterDataTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="master_data_type_id", BaseColumnName ="master_data_type_id", BaseTableName = "master_data" )]		
		public Int32 MasterDataTypeId 
		{ 
		    get { return _masterDataTypeId; } 
			set 
			{
			    _masterDataTypeId = value;
			}
        }

		private String _masterItemName;
		[DataMember]
		[SqlField(DbType.AnsiString, 500, ColumnName ="master_item_name", BaseColumnName ="master_item_name", BaseTableName = "master_data" )]		
		public String MasterItemName 
		{ 
		    get { return _masterItemName; } 
			set 
			{
			    _masterItemName = value;
			}
        }

		private String _masterItemDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 500, ColumnName ="master_item_description", BaseColumnName ="master_item_description", BaseTableName = "master_data" )]		
		public String MasterItemDescription 
		{ 
		    get { return _masterItemDescription; } 
			set 
			{
			    _masterItemDescription = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "master_data" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "master_data" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "master_data" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "master_data" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "master_data" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private Int32? _ordinal;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ordinal", BaseColumnName ="ordinal", BaseTableName = "master_data" )]		
		public Int32? Ordinal 
		{ 
		    get { return _ordinal; } 
			set 
			{
			    _ordinal = value;
			}
        }

		private String _typeName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="type_name" )]		
		public String TypeName 
		{ 
		    get { return _typeName; } 
			set 
			{
			    _typeName = value;
			}
        }

		private String _creatorName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="creator_name" )]		
		public String CreatorName 
		{ 
		    get { return _creatorName; } 
			set 
			{
			    _creatorName = value;
			}
        }

		private String _modifierName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="modifier_name" )]		
		public String ModifierName 
		{ 
		    get { return _modifierName; } 
			set 
			{
			    _modifierName = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[master_item_id], [master_data_type_id], [master_item_name], [master_item_description], [created_date], [created_by], [modified_date], [modified_by], [is_active], [ordinal]";
		public const string BasicProjectionColumnList = "[master_item_id], [master_data_type_id], [master_item_name], [master_item_description], [type_name], [created_date], [created_by], [modified_date], [modified_by], [creator_name], [modifier_name], [is_active]";

	}

	public partial class MasterDataRepository : Repository<MasterData> 
	{
		public MasterDataRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public MasterData Get(string projectionName, Int32 masterItemId)
		{
			return ((IRepository<MasterData>)this).Get(projectionName, masterItemId, FetchMode.UseIdentityMap);
		}

		public MasterData Get(string projectionName, Int32 masterItemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<MasterData>)this).Get(projectionName, masterItemId, fetchMode);
		}

		public MasterData Get(Projection projection, Int32 masterItemId)
		{
			return ((IRepository<MasterData>)this).Get(projection, masterItemId, FetchMode.UseIdentityMap);
		}

		public MasterData Get(Projection projection, Int32 masterItemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<MasterData>)this).Get(projection, masterItemId, fetchMode);
		}

		public MasterData Get(string projectionName, Int32 masterItemId, params string[] fields)
		{
			return ((IRepository<MasterData>)this).Get(projectionName, masterItemId, fields);
		}

		public MasterData Get(Projection projection, Int32 masterItemId, params string[] fields)
		{
			return ((IRepository<MasterData>)this).Get(projection, masterItemId, fields);
		}

		public bool Delete(Int32 masterItemId)
		{
			var entity = new MasterData { MasterItemId = masterItemId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<MasterData> GetAsync(string projectionName, Int32 masterItemId)
		{
			return ((IRepository<MasterData>)this).GetAsync(projectionName, masterItemId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<MasterData> GetAsync(string projectionName, Int32 masterItemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<MasterData>)this).GetAsync(projectionName, masterItemId, fetchMode);
		}

		public System.Threading.Tasks.Task<MasterData> GetAsync(Projection projection, Int32 masterItemId)
		{
			return ((IRepository<MasterData>)this).GetAsync(projection, masterItemId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<MasterData> GetAsync(Projection projection, Int32 masterItemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<MasterData>)this).GetAsync(projection, masterItemId, fetchMode);
		}

		public System.Threading.Tasks.Task<MasterData> GetAsync(string projectionName, Int32 masterItemId, params string[] fields)
		{
			return ((IRepository<MasterData>)this).GetAsync(projectionName, masterItemId, fields);
		}

		public System.Threading.Tasks.Task<MasterData> GetAsync(Projection projection, Int32 masterItemId, params string[] fields)
		{
			return ((IRepository<MasterData>)this).GetAsync(projection, masterItemId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 masterItemId)
		{
			var entity = new MasterData { MasterItemId = masterItemId };
			return this.DeleteAsync(entity);
		}
			}
	[Obsolete("Use nameof instead")]
	public static partial class MasterDataFields
	{
		public const string MasterItemId = "MasterItemId";
		public const string MasterDataTypeId = "MasterDataTypeId";
		public const string MasterItemName = "MasterItemName";
		public const string MasterItemDescription = "MasterItemDescription";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string IsActive = "IsActive";
		public const string Ordinal = "Ordinal";
		public const string TypeName = "TypeName";
		public const string CreatorName = "CreatorName";
		public const string ModifierName = "ModifierName";
	}

	public static partial class MasterDataProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="roles")]
	public partial class Role
	{
		private RoleId _roleId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="role_id", BaseColumnName ="role_id", BaseTableName = "roles" )]		
		public RoleId RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private String _roleName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name", BaseColumnName ="role_name", BaseTableName = "roles" )]		
		public String RoleName 
		{ 
		    get { return _roleName; } 
			set 
			{
			    _roleName = value;
			}
        }

		private String _roleDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_description", BaseColumnName ="role_description", BaseTableName = "roles" )]		
		public String RoleDescription 
		{ 
		    get { return _roleDescription; } 
			set 
			{
			    _roleDescription = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[role_id], [role_name], [role_description]";

	}

	public partial class RoleRepository : Repository<Role> 
	{
		public RoleRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Role Get(string projectionName, RoleId roleId)
		{
			return ((IRepository<Role>)this).Get(projectionName, roleId, FetchMode.UseIdentityMap);
		}

		public Role Get(string projectionName, RoleId roleId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Role>)this).Get(projectionName, roleId, fetchMode);
		}

		public Role Get(Projection projection, RoleId roleId)
		{
			return ((IRepository<Role>)this).Get(projection, roleId, FetchMode.UseIdentityMap);
		}

		public Role Get(Projection projection, RoleId roleId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Role>)this).Get(projection, roleId, fetchMode);
		}

		public Role Get(string projectionName, RoleId roleId, params string[] fields)
		{
			return ((IRepository<Role>)this).Get(projectionName, roleId, fields);
		}

		public Role Get(Projection projection, RoleId roleId, params string[] fields)
		{
			return ((IRepository<Role>)this).Get(projection, roleId, fields);
		}

		public bool Delete(RoleId roleId)
		{
			var entity = new Role { RoleId = roleId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<Role> GetAsync(string projectionName, RoleId roleId)
		{
			return ((IRepository<Role>)this).GetAsync(projectionName, roleId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Role> GetAsync(string projectionName, RoleId roleId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Role>)this).GetAsync(projectionName, roleId, fetchMode);
		}

		public System.Threading.Tasks.Task<Role> GetAsync(Projection projection, RoleId roleId)
		{
			return ((IRepository<Role>)this).GetAsync(projection, roleId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Role> GetAsync(Projection projection, RoleId roleId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Role>)this).GetAsync(projection, roleId, fetchMode);
		}

		public System.Threading.Tasks.Task<Role> GetAsync(string projectionName, RoleId roleId, params string[] fields)
		{
			return ((IRepository<Role>)this).GetAsync(projectionName, roleId, fields);
		}

		public System.Threading.Tasks.Task<Role> GetAsync(Projection projection, RoleId roleId, params string[] fields)
		{
			return ((IRepository<Role>)this).GetAsync(projection, roleId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(RoleId roleId)
		{
			var entity = new Role { RoleId = roleId };
			return this.DeleteAsync(entity);
		}
			}
	[Obsolete("Use nameof instead")]
	public static partial class RoleFields
	{
		public const string RoleId = "RoleId";
		public const string RoleName = "RoleName";
		public const string RoleDescription = "RoleDescription";
	}

	public static partial class RoleProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="user_roles")]
	public partial class UserRole
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_roles" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private RoleId _roleId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="role_id", BaseColumnName ="role_id", BaseTableName = "user_roles" )]		
		public RoleId RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private String _roleName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name" )]		
		public String RoleName 
		{ 
		    get { return _roleName; } 
			set 
			{
			    _roleName = value;
			}
        }

		private String _roleDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_description" )]		
		public String RoleDescription 
		{ 
		    get { return _roleDescription; } 
			set 
			{
			    _roleDescription = value;
			}
        }

		private String _userName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_name" )]		
		public String UserName 
		{ 
		    get { return _userName; } 
			set 
			{
			    _userName = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [role_id]";
		public const string BasicProjectionColumnList = "[user_id], [role_id], [role_name], [role_description], [user_name], [is_active]";

	}

	public partial class UserRoleRepository : Repository<UserRole> 
	{
		public UserRoleRepository(DataService DataService) : base(DataService)
		{
		}

		public new InsurancesDataService  DataService  
		{
			get { return (InsurancesDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	[Obsolete("Use nameof instead")]
	public static partial class UserRoleFields
	{
		public const string UserId = "UserId";
		public const string RoleId = "RoleId";
		public const string RoleName = "RoleName";
		public const string RoleDescription = "RoleDescription";
		public const string UserName = "UserName";
		public const string IsActive = "IsActive";
	}

	public static partial class UserRoleProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
}

namespace WebApi.Entities
{
	public enum RoleId
	{
		Administrator = 1,
		Delegator = 2,
		CustomerServiceStore = 3,
		CustomerExcellence = 4,
		Viewer = 5,
		TotalAccess = 6,
		CustomerServiceLoan = 7,
		Rotary = 8,
		Storage = 9,
		ReverseEpisodeStatus = 10,
		ViewAllWalkingImplants = 11,
		ViewMyWalkingImplants = 12,
	}
}

namespace WebApi.Entities
{
	public partial class InsurancesDataService : DataService
	{
		partial void OnCreated();

		private void Init()
		{
			EntityNameToEntityViewTransform = TextTransform.ToUnderscoreLowerCaseNamingConvention;
			EntityLiteProvider.DefaultSchema = "dbo";
			AuditDateTimeKind = DateTimeKind.Utc;
			OnCreated();
		}

        public InsurancesDataService() : base("Insurances")
        {
			Init();
        }

        public InsurancesDataService(string connectionStringName) : base(connectionStringName)
        {
			Init();
        }

        public InsurancesDataService(string connectionString, string providerName) : base(connectionString, providerName)
        {
			Init();
        }

		private WebApi.Entities.UserRepository _UserRepository;
		public WebApi.Entities.UserRepository UserRepository
		{
			get 
			{
				if ( _UserRepository == null)
				{
					_UserRepository = new WebApi.Entities.UserRepository(this);
				}
				return _UserRepository;
			}
		}

		private WebApi.Entities.UserPropertiesRepository _UserPropertiesRepository;
		public WebApi.Entities.UserPropertiesRepository UserPropertiesRepository
		{
			get 
			{
				if ( _UserPropertiesRepository == null)
				{
					_UserPropertiesRepository = new WebApi.Entities.UserPropertiesRepository(this);
				}
				return _UserPropertiesRepository;
			}
		}

		private WebApi.Entities.UserPasswordHistoryRepository _UserPasswordHistoryRepository;
		public WebApi.Entities.UserPasswordHistoryRepository UserPasswordHistoryRepository
		{
			get 
			{
				if ( _UserPasswordHistoryRepository == null)
				{
					_UserPasswordHistoryRepository = new WebApi.Entities.UserPasswordHistoryRepository(this);
				}
				return _UserPasswordHistoryRepository;
			}
		}

		private WebApi.Entities.MasterDataRepository _MasterDataRepository;
		public WebApi.Entities.MasterDataRepository MasterDataRepository
		{
			get 
			{
				if ( _MasterDataRepository == null)
				{
					_MasterDataRepository = new WebApi.Entities.MasterDataRepository(this);
				}
				return _MasterDataRepository;
			}
		}

		private WebApi.Entities.RoleRepository _RoleRepository;
		public WebApi.Entities.RoleRepository RoleRepository
		{
			get 
			{
				if ( _RoleRepository == null)
				{
					_RoleRepository = new WebApi.Entities.RoleRepository(this);
				}
				return _RoleRepository;
			}
		}

		private WebApi.Entities.UserRoleRepository _UserRoleRepository;
		public WebApi.Entities.UserRoleRepository UserRoleRepository
		{
			get 
			{
				if ( _UserRoleRepository == null)
				{
					_UserRoleRepository = new WebApi.Entities.UserRoleRepository(this);
				}
				return _UserRoleRepository;
			}
		}
	}
}
