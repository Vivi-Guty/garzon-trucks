
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
    [TypeScript] 
	[SqlEntity(BaseTableName="texts")]
	public partial class Text
	{
		private Int32 _textId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "texts_text_id_seq", ColumnName ="text_id", BaseColumnName ="text_id", BaseTableName = "texts" )]		
		public Int32 TextId 
		{ 
		    get { return _textId; } 
			set 
			{
			    _textId = value;
			}
        }

		private String _nameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="name_localizable", BaseColumnName ="name_localizable", BaseTableName = "texts" )]		
		public String NameLocalizable 
		{ 
		    get { return _nameLocalizable; } 
			set 
			{
			    _nameLocalizable = value;
			}
        }

		private String _textEn;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_en", BaseColumnName ="text_en", BaseTableName = "texts" )]		
		public String TextEn 
		{ 
		    get { return _textEn; } 
			set 
			{
			    _textEn = value;
			}
        }

		private String _textEs;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_es", BaseColumnName ="text_es", BaseTableName = "texts" )]		
		public String TextEs 
		{ 
		    get { return _textEs; } 
			set 
			{
			    _textEs = value;
			}
        }

		private String _textCs;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_cs", BaseColumnName ="text_cs", BaseTableName = "texts" )]		
		public String TextCs 
		{ 
		    get { return _textCs; } 
			set 
			{
			    _textCs = value;
			}
        }

		private String _textHu;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_hu", BaseColumnName ="text_hu", BaseTableName = "texts" )]		
		public String TextHu 
		{ 
		    get { return _textHu; } 
			set 
			{
			    _textHu = value;
			}
        }

		private String _textPl;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_pl", BaseColumnName ="text_pl", BaseTableName = "texts" )]		
		public String TextPl 
		{ 
		    get { return _textPl; } 
			set 
			{
			    _textPl = value;
			}
        }

		private String _textRo;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ro", BaseColumnName ="text_ro", BaseTableName = "texts" )]		
		public String TextRo 
		{ 
		    get { return _textRo; } 
			set 
			{
			    _textRo = value;
			}
        }

		private String _textRu;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ru", BaseColumnName ="text_ru", BaseTableName = "texts" )]		
		public String TextRu 
		{ 
		    get { return _textRu; } 
			set 
			{
			    _textRu = value;
			}
        }

		private String _textBg;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_bg", BaseColumnName ="text_bg", BaseTableName = "texts" )]		
		public String TextBg 
		{ 
		    get { return _textBg; } 
			set 
			{
			    _textBg = value;
			}
        }

		private String _textUk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_uk", BaseColumnName ="text_uk", BaseTableName = "texts" )]		
		public String TextUk 
		{ 
		    get { return _textUk; } 
			set 
			{
			    _textUk = value;
			}
        }

		private String _textKk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_kk", BaseColumnName ="text_kk", BaseTableName = "texts" )]		
		public String TextKk 
		{ 
		    get { return _textKk; } 
			set 
			{
			    _textKk = value;
			}
        }

		private String _textBe;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_be", BaseColumnName ="text_be", BaseTableName = "texts" )]		
		public String TextBe 
		{ 
		    get { return _textBe; } 
			set 
			{
			    _textBe = value;
			}
        }

		private String _textSk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_sk", BaseColumnName ="text_sk", BaseTableName = "texts" )]		
		public String TextSk 
		{ 
		    get { return _textSk; } 
			set 
			{
			    _textSk = value;
			}
        }

		private String _textFr;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_fr", BaseColumnName ="text_fr", BaseTableName = "texts" )]		
		public String TextFr 
		{ 
		    get { return _textFr; } 
			set 
			{
			    _textFr = value;
			}
        }

		private String _textZh;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_zh", BaseColumnName ="text_zh", BaseTableName = "texts" )]		
		public String TextZh 
		{ 
		    get { return _textZh; } 
			set 
			{
			    _textZh = value;
			}
        }

		private String _textKo;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ko", BaseColumnName ="text_ko", BaseTableName = "texts" )]		
		public String TextKo 
		{ 
		    get { return _textKo; } 
			set 
			{
			    _textKo = value;
			}
        }

		private String _textDe;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_de", BaseColumnName ="text_de", BaseTableName = "texts" )]		
		public String TextDe 
		{ 
		    get { return _textDe; } 
			set 
			{
			    _textDe = value;
			}
        }

		private String _textAt;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_at", BaseColumnName ="text_at", BaseTableName = "texts" )]		
		public String TextAt 
		{ 
		    get { return _textAt; } 
			set 
			{
			    _textAt = value;
			}
        }

		private String _textIt;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_it", BaseColumnName ="text_it", BaseTableName = "texts" )]		
		public String TextIt 
		{ 
		    get { return _textIt; } 
			set 
			{
			    _textIt = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[text_id], [name_localizable], [text_en], [text_es], [text_cs], [text_hu], [text_pl], [text_ro], [text_ru], [text_bg], [text_uk], [text_kk], [text_be], [text_sk], [text_fr], [text_zh], [text_ko], [text_de], [text_at], [text_it]";

	}

	public partial class TextRepository : Repository<Text> 
	{
		public TextRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Text Get(string projectionName, Int32 textId)
		{
			return ((IRepository<Text>)this).Get(projectionName, textId, FetchMode.UseIdentityMap);
		}

		public Text Get(string projectionName, Int32 textId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Text>)this).Get(projectionName, textId, fetchMode);
		}

		public Text Get(Projection projection, Int32 textId)
		{
			return ((IRepository<Text>)this).Get(projection, textId, FetchMode.UseIdentityMap);
		}

		public Text Get(Projection projection, Int32 textId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Text>)this).Get(projection, textId, fetchMode);
		}

		public Text Get(string projectionName, Int32 textId, params string[] fields)
		{
			return ((IRepository<Text>)this).Get(projectionName, textId, fields);
		}

		public Text Get(Projection projection, Int32 textId, params string[] fields)
		{
			return ((IRepository<Text>)this).Get(projection, textId, fields);
		}

		public bool Delete(Int32 textId)
		{
			var entity = new Text { TextId = textId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<Text> GetAsync(string projectionName, Int32 textId)
		{
			return ((IRepository<Text>)this).GetAsync(projectionName, textId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Text> GetAsync(string projectionName, Int32 textId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Text>)this).GetAsync(projectionName, textId, fetchMode);
		}

		public System.Threading.Tasks.Task<Text> GetAsync(Projection projection, Int32 textId)
		{
			return ((IRepository<Text>)this).GetAsync(projection, textId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Text> GetAsync(Projection projection, Int32 textId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Text>)this).GetAsync(projection, textId, fetchMode);
		}

		public System.Threading.Tasks.Task<Text> GetAsync(string projectionName, Int32 textId, params string[] fields)
		{
			return ((IRepository<Text>)this).GetAsync(projectionName, textId, fields);
		}

		public System.Threading.Tasks.Task<Text> GetAsync(Projection projection, Int32 textId, params string[] fields)
		{
			return ((IRepository<Text>)this).GetAsync(projection, textId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 textId)
		{
			var entity = new Text { TextId = textId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class TextFields
	{
		public const string TextId = "TextId";
		public const string NameLocalizable = "NameLocalizable";
		public const string TextEn = "TextEn";
		public const string TextEs = "TextEs";
		public const string TextCs = "TextCs";
		public const string TextHu = "TextHu";
		public const string TextPl = "TextPl";
		public const string TextRo = "TextRo";
		public const string TextRu = "TextRu";
		public const string TextBg = "TextBg";
		public const string TextUk = "TextUk";
		public const string TextKk = "TextKk";
		public const string TextBe = "TextBe";
		public const string TextSk = "TextSk";
		public const string TextFr = "TextFr";
		public const string TextZh = "TextZh";
		public const string TextKo = "TextKo";
		public const string TextDe = "TextDe";
		public const string TextAt = "TextAt";
		public const string TextIt = "TextIt";
	}

	public static partial class TextProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="reference_data_etag")]
	public partial class ReferenceDataEtag
	{
		private Guid _etag;
		[DataMember]
		[SqlField(DbType.Guid, 16, ColumnName ="etag", BaseColumnName ="etag", BaseTableName = "reference_data_etag" )]		
		public Guid Etag 
		{ 
		    get { return _etag; } 
			set 
			{
			    _etag = value;
			}
        }

		private String _etagType;
		[DataMember]
		[SqlField(DbType.AnsiString, 50, ColumnName ="etag_type", BaseColumnName ="etag_type", BaseTableName = "reference_data_etag" )]		
		public String EtagType 
		{ 
		    get { return _etagType; } 
			set 
			{
			    _etagType = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[etag], [etag_type]";

	}

	public partial class ReferenceDataEtagRepository : Repository<ReferenceDataEtag> 
	{
		public ReferenceDataEtagRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class ReferenceDataEtagFields
	{
		public const string Etag = "Etag";
		public const string EtagType = "EtagType";
	}

	public static partial class ReferenceDataEtagProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="reference_table_item_types")]
	public partial class ReferenceTableItemType
	{
		private Int32 _itemTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "reference_table_item_types_item_type_id_seq", ColumnName ="item_type_id", BaseColumnName ="item_type_id", BaseTableName = "reference_table_item_types" )]		
		public Int32 ItemTypeId 
		{ 
		    get { return _itemTypeId; } 
			set 
			{
			    _itemTypeId = value;
			}
        }

		private String _itemName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="item_name", BaseColumnName ="item_name", BaseTableName = "reference_table_item_types" )]		
		public String ItemName 
		{ 
		    get { return _itemName; } 
			set 
			{
			    _itemName = value;
			}
        }

		private String _itemNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="item_name_localizable", BaseColumnName ="item_name_localizable", BaseTableName = "reference_table_item_types" )]		
		public String ItemNameLocalizable 
		{ 
		    get { return _itemNameLocalizable; } 
			set 
			{
			    _itemNameLocalizable = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[item_type_id], [item_name], [item_name_localizable]";

	}

	public partial class ReferenceTableItemTypeRepository : Repository<ReferenceTableItemType> 
	{
		public ReferenceTableItemTypeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public ReferenceTableItemType Get(string projectionName, Int32 itemTypeId)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projectionName, itemTypeId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItemType Get(string projectionName, Int32 itemTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projectionName, itemTypeId, fetchMode);
		}

		public ReferenceTableItemType Get(Projection projection, Int32 itemTypeId)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projection, itemTypeId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItemType Get(Projection projection, Int32 itemTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projection, itemTypeId, fetchMode);
		}

		public ReferenceTableItemType Get(string projectionName, Int32 itemTypeId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projectionName, itemTypeId, fields);
		}

		public ReferenceTableItemType Get(Projection projection, Int32 itemTypeId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemType>)this).Get(projection, itemTypeId, fields);
		}

		public bool Delete(Int32 itemTypeId)
		{
			var entity = new ReferenceTableItemType { ItemTypeId = itemTypeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(string projectionName, Int32 itemTypeId)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projectionName, itemTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(string projectionName, Int32 itemTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projectionName, itemTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(Projection projection, Int32 itemTypeId)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projection, itemTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(Projection projection, Int32 itemTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projection, itemTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(string projectionName, Int32 itemTypeId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projectionName, itemTypeId, fields);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemType> GetAsync(Projection projection, Int32 itemTypeId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemType>)this).GetAsync(projection, itemTypeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 itemTypeId)
		{
			var entity = new ReferenceTableItemType { ItemTypeId = itemTypeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class ReferenceTableItemTypeFields
	{
		public const string ItemTypeId = "ItemTypeId";
		public const string ItemName = "ItemName";
		public const string ItemNameLocalizable = "ItemNameLocalizable";
	}

	public static partial class ReferenceTableItemTypeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="reference_table_item_map_forms")]
	public partial class ReferenceTableItemMapForm
	{
		private Int32 _imId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "reference_table_item_map_forms_im_id_seq", ColumnName ="im_id", BaseColumnName ="im_id", BaseTableName = "reference_table_item_map_forms" )]		
		public Int32 ImId 
		{ 
		    get { return _imId; } 
			set 
			{
			    _imId = value;
			}
        }

		private Int32 _itemId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="item_id", BaseColumnName ="item_id", BaseTableName = "reference_table_item_map_forms" )]		
		public Int32 ItemId 
		{ 
		    get { return _itemId; } 
			set 
			{
			    _itemId = value;
			}
        }

		private Int32 _mapFormId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="map_form_id", BaseColumnName ="map_form_id", BaseTableName = "reference_table_item_map_forms" )]		
		public Int32 MapFormId 
		{ 
		    get { return _mapFormId; } 
			set 
			{
			    _mapFormId = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "reference_table_item_map_forms" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "reference_table_item_map_forms" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[im_id], [item_id], [map_form_id], [created_date], [created_by]";

	}

	public partial class ReferenceTableItemMapFormRepository : Repository<ReferenceTableItemMapForm> 
	{
		public ReferenceTableItemMapFormRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public ReferenceTableItemMapForm Get(string projectionName, Int32 imId)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projectionName, imId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItemMapForm Get(string projectionName, Int32 imId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projectionName, imId, fetchMode);
		}

		public ReferenceTableItemMapForm Get(Projection projection, Int32 imId)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projection, imId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItemMapForm Get(Projection projection, Int32 imId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projection, imId, fetchMode);
		}

		public ReferenceTableItemMapForm Get(string projectionName, Int32 imId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projectionName, imId, fields);
		}

		public ReferenceTableItemMapForm Get(Projection projection, Int32 imId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).Get(projection, imId, fields);
		}

		public bool Delete(Int32 imId)
		{
			var entity = new ReferenceTableItemMapForm { ImId = imId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(string projectionName, Int32 imId)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projectionName, imId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(string projectionName, Int32 imId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projectionName, imId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(Projection projection, Int32 imId)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projection, imId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(Projection projection, Int32 imId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projection, imId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(string projectionName, Int32 imId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projectionName, imId, fields);
		}

		public System.Threading.Tasks.Task<ReferenceTableItemMapForm> GetAsync(Projection projection, Int32 imId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItemMapForm>)this).GetAsync(projection, imId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 imId)
		{
			var entity = new ReferenceTableItemMapForm { ImId = imId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class ReferenceTableItemMapFormFields
	{
		public const string ImId = "ImId";
		public const string ItemId = "ItemId";
		public const string MapFormId = "MapFormId";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
	}

	public static partial class ReferenceTableItemMapFormProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="reference_table_items")]
	public partial class ReferenceTableItem
	{
		private Int32 _itemId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "reference_table_items_item_id_seq", ColumnName ="item_id", BaseColumnName ="item_id", BaseTableName = "reference_table_items" )]		
		public Int32 ItemId 
		{ 
		    get { return _itemId; } 
			set 
			{
			    _itemId = value;
			}
        }

		private String _itemNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="item_name_localizable", BaseColumnName ="item_name_localizable", BaseTableName = "reference_table_items" )]		
		public String ItemNameLocalizable 
		{ 
		    get { return _itemNameLocalizable; } 
			set 
			{
			    _itemNameLocalizable = value;
			}
        }

		private String _itemCode;
		[DataMember]
		[SqlField(DbType.String, 50, ColumnName ="item_code", BaseColumnName ="item_code", BaseTableName = "reference_table_items" )]		
		public String ItemCode 
		{ 
		    get { return _itemCode; } 
			set 
			{
			    _itemCode = value;
			}
        }

		private Int32 _itemTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="item_type_id", BaseColumnName ="item_type_id", BaseTableName = "reference_table_items" )]		
		public Int32 ItemTypeId 
		{ 
		    get { return _itemTypeId; } 
			set 
			{
			    _itemTypeId = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "reference_table_items" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "reference_table_items" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "reference_table_items" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "reference_table_items" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "reference_table_items" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32? _itemOrder;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="item_order", BaseColumnName ="item_order", BaseTableName = "reference_table_items" )]		
		public Int32? ItemOrder 
		{ 
		    get { return _itemOrder; } 
			set 
			{
			    _itemOrder = value;
			}
        }

		private String _itemTypeParentNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="item_type_parent_name_localizable" )]		
		public String ItemTypeParentNameLocalizable 
		{ 
		    get { return _itemTypeParentNameLocalizable; } 
			set 
			{
			    _itemTypeParentNameLocalizable = value;
			}
        }

		private Int32? _textId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, AllowNull = true, ColumnName ="text_id" )]		
		public Int32? TextId 
		{ 
		    get { return _textId; } 
			set 
			{
			    _textId = value;
			}
        }

		private String _nameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="name_localizable" )]		
		public String NameLocalizable 
		{ 
		    get { return _nameLocalizable; } 
			set 
			{
			    _nameLocalizable = value;
			}
        }

		private String _textEn;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_en" )]		
		public String TextEn 
		{ 
		    get { return _textEn; } 
			set 
			{
			    _textEn = value;
			}
        }

		private String _textEs;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_es" )]		
		public String TextEs 
		{ 
		    get { return _textEs; } 
			set 
			{
			    _textEs = value;
			}
        }

		private String _textCs;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_cs" )]		
		public String TextCs 
		{ 
		    get { return _textCs; } 
			set 
			{
			    _textCs = value;
			}
        }

		private String _textHu;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_hu" )]		
		public String TextHu 
		{ 
		    get { return _textHu; } 
			set 
			{
			    _textHu = value;
			}
        }

		private String _textPl;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_pl" )]		
		public String TextPl 
		{ 
		    get { return _textPl; } 
			set 
			{
			    _textPl = value;
			}
        }

		private String _textRo;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ro" )]		
		public String TextRo 
		{ 
		    get { return _textRo; } 
			set 
			{
			    _textRo = value;
			}
        }

		private String _textRu;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ru" )]		
		public String TextRu 
		{ 
		    get { return _textRu; } 
			set 
			{
			    _textRu = value;
			}
        }

		private String _textBg;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_bg" )]		
		public String TextBg 
		{ 
		    get { return _textBg; } 
			set 
			{
			    _textBg = value;
			}
        }

		private String _textUk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_uk" )]		
		public String TextUk 
		{ 
		    get { return _textUk; } 
			set 
			{
			    _textUk = value;
			}
        }

		private String _textKk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_kk" )]		
		public String TextKk 
		{ 
		    get { return _textKk; } 
			set 
			{
			    _textKk = value;
			}
        }

		private String _textBe;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_be" )]		
		public String TextBe 
		{ 
		    get { return _textBe; } 
			set 
			{
			    _textBe = value;
			}
        }

		private String _textSk;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_sk" )]		
		public String TextSk 
		{ 
		    get { return _textSk; } 
			set 
			{
			    _textSk = value;
			}
        }

		private String _textFr;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_fr" )]		
		public String TextFr 
		{ 
		    get { return _textFr; } 
			set 
			{
			    _textFr = value;
			}
        }

		private String _textZh;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_zh" )]		
		public String TextZh 
		{ 
		    get { return _textZh; } 
			set 
			{
			    _textZh = value;
			}
        }

		private String _textKo;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_ko" )]		
		public String TextKo 
		{ 
		    get { return _textKo; } 
			set 
			{
			    _textKo = value;
			}
        }

		private String _textDe;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_de" )]		
		public String TextDe 
		{ 
		    get { return _textDe; } 
			set 
			{
			    _textDe = value;
			}
        }

		private String _textAt;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_at" )]		
		public String TextAt 
		{ 
		    get { return _textAt; } 
			set 
			{
			    _textAt = value;
			}
        }

		private String _textIt;
		[DataMember]
		[SqlField(DbType.String, 4000, ColumnName ="text_it" )]		
		public String TextIt 
		{ 
		    get { return _textIt; } 
			set 
			{
			    _textIt = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[item_id], [item_name_localizable], [item_code], [item_type_id], [is_active], [created_by], [created_date], [modified_by], [modified_date], [item_order]";
		public const string BasicProjectionColumnList = "[item_id], [item_name_localizable], [item_type_parent_name_localizable], [item_code], [item_type_id], [item_order], [is_active], [created_by], [created_date], [modified_by], [modified_date], [text_id], [name_localizable], [text_en], [text_es], [text_cs], [text_hu], [text_pl], [text_ro], [text_ru], [text_bg], [text_uk], [text_kk], [text_be], [text_sk], [text_fr], [text_zh], [text_ko], [text_de], [text_at], [text_it]";

	}

	public partial class ReferenceTableItemRepository : Repository<ReferenceTableItem> 
	{
		public ReferenceTableItemRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public ReferenceTableItem Get(string projectionName, Int32 itemId)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projectionName, itemId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItem Get(string projectionName, Int32 itemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projectionName, itemId, fetchMode);
		}

		public ReferenceTableItem Get(Projection projection, Int32 itemId)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projection, itemId, FetchMode.UseIdentityMap);
		}

		public ReferenceTableItem Get(Projection projection, Int32 itemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projection, itemId, fetchMode);
		}

		public ReferenceTableItem Get(string projectionName, Int32 itemId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projectionName, itemId, fields);
		}

		public ReferenceTableItem Get(Projection projection, Int32 itemId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItem>)this).Get(projection, itemId, fields);
		}

		public bool Delete(Int32 itemId)
		{
			var entity = new ReferenceTableItem { ItemId = itemId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(string projectionName, Int32 itemId)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projectionName, itemId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(string projectionName, Int32 itemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projectionName, itemId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(Projection projection, Int32 itemId)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projection, itemId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(Projection projection, Int32 itemId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projection, itemId, fetchMode);
		}

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(string projectionName, Int32 itemId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projectionName, itemId, fields);
		}

		public System.Threading.Tasks.Task<ReferenceTableItem> GetAsync(Projection projection, Int32 itemId, params string[] fields)
		{
			return ((IRepository<ReferenceTableItem>)this).GetAsync(projection, itemId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 itemId)
		{
			var entity = new ReferenceTableItem { ItemId = itemId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class ReferenceTableItemFields
	{
		public const string ItemId = "ItemId";
		public const string ItemNameLocalizable = "ItemNameLocalizable";
		public const string ItemCode = "ItemCode";
		public const string ItemTypeId = "ItemTypeId";
		public const string IsActive = "IsActive";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ItemOrder = "ItemOrder";
		public const string ItemTypeParentNameLocalizable = "ItemTypeParentNameLocalizable";
		public const string TextId = "TextId";
		public const string NameLocalizable = "NameLocalizable";
		public const string TextEn = "TextEn";
		public const string TextEs = "TextEs";
		public const string TextCs = "TextCs";
		public const string TextHu = "TextHu";
		public const string TextPl = "TextPl";
		public const string TextRo = "TextRo";
		public const string TextRu = "TextRu";
		public const string TextBg = "TextBg";
		public const string TextUk = "TextUk";
		public const string TextKk = "TextKk";
		public const string TextBe = "TextBe";
		public const string TextSk = "TextSk";
		public const string TextFr = "TextFr";
		public const string TextZh = "TextZh";
		public const string TextKo = "TextKo";
		public const string TextDe = "TextDe";
		public const string TextAt = "TextAt";
		public const string TextIt = "TextIt";
	}

	public static partial class ReferenceTableItemProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="users")]
	[ParentPropertyName("OuId")]
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

		private String _userMail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_mail", BaseColumnName ="user_mail", BaseTableName = "users" )]		
		public String UserMail 
		{ 
		    get { return _userMail; } 
			set 
			{
			    _userMail = value;
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

		private String _cultureCode;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 5, ColumnName ="culture_code", BaseColumnName ="culture_code", BaseTableName = "users" )]		
		public String CultureCode 
		{ 
		    get { return _cultureCode; } 
			set 
			{
			    _cultureCode = value;
			}
        }

		private String _upi;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="upi", BaseColumnName ="upi", BaseTableName = "users" )]		
		public String Upi 
		{ 
		    get { return _upi; } 
			set 
			{
			    _upi = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "users" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _title;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="title", BaseColumnName ="title", BaseTableName = "users" )]		
		public String Title 
		{ 
		    get { return _title; } 
			set 
			{
			    _title = value;
			}
        }

		private Boolean _seeCompactView;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="see_compact_view", BaseColumnName ="see_compact_view", BaseTableName = "users" )]		
		public Boolean SeeCompactView 
		{ 
		    get { return _seeCompactView; } 
			set 
			{
			    _seeCompactView = value;
			}
        }

		private Int32 _loginFailedAttemptsCount;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="login_failed_attempts_count", BaseColumnName ="login_failed_attempts_count", BaseTableName = "users" )]		
		public Int32 LoginFailedAttemptsCount 
		{ 
		    get { return _loginFailedAttemptsCount; } 
			set 
			{
			    _loginFailedAttemptsCount = value;
			}
        }

		private DateTime? _lastLoginAttempt;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="last_login_attempt", BaseColumnName ="last_login_attempt", BaseTableName = "users" )]		
		public DateTime? LastLoginAttempt 
		{ 
		    get { return _lastLoginAttempt; } 
			set 
			{
			    _lastLoginAttempt = value;
			}
        }

		private Boolean _hideAudit;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="hide_audit", BaseColumnName ="hide_audit", BaseTableName = "users" )]		
		public Boolean HideAudit 
		{ 
		    get { return _hideAudit; } 
			set 
			{
			    _hideAudit = value;
			}
        }

		private String _division;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="division", BaseColumnName ="division", BaseTableName = "users" )]		
		public String Division 
		{ 
		    get { return _division; } 
			set 
			{
			    _division = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [user_name], [user_mail], [is_active], [created_date], [created_by], [modified_date], [modified_by], [login_name], [culture_code], [upi], [ou_id], [title], [see_compact_view], [login_failed_attempts_count], [last_login_attempt], [hide_audit], [division]";

	}

	public partial class UserRepository : Repository<User> 
	{
		public UserRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
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
		
		public void SetContextInfo(String languageCode, Int32? userId)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateSetContextInfoProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "LanguageCode"].Value = languageCode == null ? (object) DBNull.Value : languageCode;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "UserId"].Value = userId == null ? (object) DBNull.Value : userId.Value;
                    return proc;
                }
            };

			executor.ExecuteNonQuery();
		}

		public async System.Threading.Tasks.Task SetContextInfoAsync(String languageCode, Int32? userId)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateSetContextInfoProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "LanguageCode"].Value = languageCode == null ? (object) DBNull.Value : languageCode;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "UserId"].Value = userId == null ? (object) DBNull.Value : userId.Value;
                    return proc;
                }
            };

			await executor.ExecuteNonQueryAsync().ConfigureAwait(false);
		}
	}
	// [Obsolete("Use nameof instead")]
	public static partial class UserFields
	{
		public const string UserId = "UserId";
		public const string UserName = "UserName";
		public const string UserMail = "UserMail";
		public const string IsActive = "IsActive";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string LoginName = "LoginName";
		public const string CultureCode = "CultureCode";
		public const string Upi = "Upi";
		public const string OuId = "OuId";
		public const string Title = "Title";
		public const string SeeCompactView = "SeeCompactView";
		public const string LoginFailedAttemptsCount = "LoginFailedAttemptsCount";
		public const string LastLoginAttempt = "LastLoginAttempt";
		public const string HideAudit = "HideAudit";
		public const string Division = "Division";
	}

	public static partial class UserProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
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

		private String _roleNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name_localizable", BaseColumnName ="role_name_localizable", BaseTableName = "roles" )]		
		public String RoleNameLocalizable 
		{ 
		    get { return _roleNameLocalizable; } 
			set 
			{
			    _roleNameLocalizable = value;
			}
        }

		private String _roleDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 1000, ColumnName ="role_description", BaseColumnName ="role_description", BaseTableName = "roles" )]		
		public String RoleDescription 
		{ 
		    get { return _roleDescription; } 
			set 
			{
			    _roleDescription = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "roles" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "roles" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "roles" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "roles" )]		
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
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "roles" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ordinal", BaseColumnName ="ordinal", BaseTableName = "roles" )]		
		public Int32? Ordinal 
		{ 
		    get { return _ordinal; } 
			set 
			{
			    _ordinal = value;
			}
        }

		private PermissionId _permissionId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="permission_id" )]		
		public PermissionId PermissionId 
		{ 
		    get { return _permissionId; } 
			set 
			{
			    _permissionId = value;
			}
        }

		private String _permissionNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="permission_name_localizable" )]		
		public String PermissionNameLocalizable 
		{ 
		    get { return _permissionNameLocalizable; } 
			set 
			{
			    _permissionNameLocalizable = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[role_id], [role_name_localizable], [role_description], [created_date], [created_by], [modified_date], [modified_by], [is_active], [ordinal]";
		public const string PermissionBasicProjectionColumnList = "[role_id], [role_name_localizable], [permission_id], [permission_name_localizable]";

	}

	public partial class RoleRepository : Repository<Role> 
	{
		public RoleRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
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
	// [Obsolete("Use nameof instead")]
	public static partial class RoleFields
	{
		public const string RoleId = "RoleId";
		public const string RoleNameLocalizable = "RoleNameLocalizable";
		public const string RoleDescription = "RoleDescription";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string IsActive = "IsActive";
		public const string Ordinal = "Ordinal";
		public const string PermissionId = "PermissionId";
		public const string PermissionNameLocalizable = "PermissionNameLocalizable";
	}

	public static partial class RoleProjections
	{
		public const string BaseTable = "BaseTable";
		public const string PermissionBasic = "PermissionBasic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="user_role_entities")]
	public partial class UserRoleEntity
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_role_entities" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="role_id", BaseColumnName ="role_id", BaseTableName = "user_role_entities" )]		
		public RoleId RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private Int32 _entityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="entity_id", BaseColumnName ="entity_id", BaseTableName = "user_role_entities" )]		
		public Int32 EntityId 
		{ 
		    get { return _entityId; } 
			set 
			{
			    _entityId = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "user_role_entities" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "user_role_entities" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private String _jobDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 256, ColumnName ="job_description", BaseColumnName ="job_description", BaseTableName = "user_role_entities" )]		
		public String JobDescription 
		{ 
		    get { return _jobDescription; } 
			set 
			{
			    _jobDescription = value;
			}
        }

		private String _roleNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name_localizable" )]		
		public String RoleNameLocalizable 
		{ 
		    get { return _roleNameLocalizable; } 
			set 
			{
			    _roleNameLocalizable = value;
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

		private String _userMail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_mail" )]		
		public String UserMail 
		{ 
		    get { return _userMail; } 
			set 
			{
			    _userMail = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32 _ouTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_type_id" )]		
		public Int32 OuTypeId 
		{ 
		    get { return _ouTypeId; } 
			set 
			{
			    _ouTypeId = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private Int32? _ouParentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, AllowNull = true, ColumnName ="ou_parent_id" )]		
		public Int32? OuParentId 
		{ 
		    get { return _ouParentId; } 
			set 
			{
			    _ouParentId = value;
			}
        }

		private String _ouParentName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_parent_name" )]		
		public String OuParentName 
		{ 
		    get { return _ouParentName; } 
			set 
			{
			    _ouParentName = value;
			}
        }

		private String _division;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="division" )]		
		public String Division 
		{ 
		    get { return _division; } 
			set 
			{
			    _division = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [role_id], [entity_id], [created_date], [created_by], [job_description]";
		public const string BasicProjectionColumnList = "[user_id], [role_id], [entity_id], [role_name_localizable], [created_date], [created_by]";
		public const string DetailedProjectionColumnList = "[user_id], [user_name], [is_active], [user_mail], [role_id], [entity_id], [role_name_localizable], [ou_id], [ou_type_id], [ou_name], [job_description], [created_date], [created_by], [ou_parent_id], [ou_parent_name], [division]";
		public const string MinimalProjectionColumnList = "[user_id], [role_id], [entity_id], [created_date], [created_by]";

	}

	public partial class UserRoleEntityRepository : Repository<UserRoleEntity> 
	{
		public UserRoleEntityRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class UserRoleEntityFields
	{
		public const string UserId = "UserId";
		public const string RoleId = "RoleId";
		public const string EntityId = "EntityId";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string JobDescription = "JobDescription";
		public const string RoleNameLocalizable = "RoleNameLocalizable";
		public const string UserName = "UserName";
		public const string IsActive = "IsActive";
		public const string UserMail = "UserMail";
		public const string OuId = "OuId";
		public const string OuTypeId = "OuTypeId";
		public const string OuName = "OuName";
		public const string OuParentId = "OuParentId";
		public const string OuParentName = "OuParentName";
		public const string Division = "Division";
	}

	public static partial class UserRoleEntityProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
		public const string Detailed = "Detailed";
		public const string Minimal = "Minimal";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity()]
	public partial class UserRole
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id" )]		
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

		private String _userMail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_mail" )]		
		public String UserMail 
		{ 
		    get { return _userMail; } 
			set 
			{
			    _userMail = value;
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

		public const string BasicProjectionColumnList = "[user_id], [login_name], [user_name], [user_mail], [role_id]";

	}

	public partial class UserRoleRepository : Repository<UserRole> 
	{
		public UserRoleRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class UserRoleFields
	{
		public const string UserId = "UserId";
		public const string LoginName = "LoginName";
		public const string UserName = "UserName";
		public const string UserMail = "UserMail";
		public const string RoleId = "RoleId";
	}

	public static partial class UserRoleProjections
	{
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity()]
	public partial class UserPermission
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="role_id" )]		
		public RoleId RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private Int32 _entityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="entity_id" )]		
		public Int32 EntityId 
		{ 
		    get { return _entityId; } 
			set 
			{
			    _entityId = value;
			}
        }

		private EntityTypeId _entityTypeId;
		[DataMember]
		[SqlField(DbType.Int16, 2, Precision = 5, ColumnName ="entity_type_id" )]		
		public EntityTypeId EntityTypeId 
		{ 
		    get { return _entityTypeId; } 
			set 
			{
			    _entityTypeId = value;
			}
        }

		private PermissionId _permissionId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="permission_id" )]		
		public PermissionId PermissionId 
		{ 
		    get { return _permissionId; } 
			set 
			{
			    _permissionId = value;
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

		private String _roleNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role_name_localizable" )]		
		public String RoleNameLocalizable 
		{ 
		    get { return _roleNameLocalizable; } 
			set 
			{
			    _roleNameLocalizable = value;
			}
        }

		private String _permissionNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="permission_name_localizable" )]		
		public String PermissionNameLocalizable 
		{ 
		    get { return _permissionNameLocalizable; } 
			set 
			{
			    _permissionNameLocalizable = value;
			}
        }

		public const string BasicProjectionColumnList = "[user_id], [role_id], [entity_id], [entity_type_id], [permission_id], [login_name], [role_name_localizable], [permission_name_localizable]";
		public const string MinimalProjectionColumnList = "[user_id], [role_id], [entity_id], [entity_type_id], [permission_id]";

	}

	public partial class UserPermissionRepository : Repository<UserPermission> 
	{
		public UserPermissionRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class UserPermissionFields
	{
		public const string UserId = "UserId";
		public const string RoleId = "RoleId";
		public const string EntityId = "EntityId";
		public const string EntityTypeId = "EntityTypeId";
		public const string PermissionId = "PermissionId";
		public const string LoginName = "LoginName";
		public const string RoleNameLocalizable = "RoleNameLocalizable";
		public const string PermissionNameLocalizable = "PermissionNameLocalizable";
	}

	public static partial class UserPermissionProjections
	{
		public const string Basic = "Basic";
		public const string Minimal = "Minimal";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity()]
	public partial class UserRoleOrganizationalUnit
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32? _ouAreaId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_area_id" )]		
		public Int32? OuAreaId 
		{ 
		    get { return _ouAreaId; } 
			set 
			{
			    _ouAreaId = value;
			}
        }

		private Int32? _ouParentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_parent_id" )]		
		public Int32? OuParentId 
		{ 
		    get { return _ouParentId; } 
			set 
			{
			    _ouParentId = value;
			}
        }

		private String _ouParentName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_parent_name" )]		
		public String OuParentName 
		{ 
		    get { return _ouParentName; } 
			set 
			{
			    _ouParentName = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private Int32 _ouTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_type_id" )]		
		public Int32 OuTypeId 
		{ 
		    get { return _ouTypeId; } 
			set 
			{
			    _ouTypeId = value;
			}
        }

		private String _ouType;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="ou_type" )]		
		public String OuType 
		{ 
		    get { return _ouType; } 
			set 
			{
			    _ouType = value;
			}
        }

		private Boolean _hasAdvisor;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_advisor" )]		
		public Boolean HasAdvisor 
		{ 
		    get { return _hasAdvisor; } 
			set 
			{
			    _hasAdvisor = value;
			}
        }

		private String _currency;
		[DataMember]
		[SqlField(DbType.AnsiString, 1006, ColumnName ="currency" )]		
		public String Currency 
		{ 
		    get { return _currency; } 
			set 
			{
			    _currency = value;
			}
        }

		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="user_id" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
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

		private String _upi;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="upi" )]		
		public String Upi 
		{ 
		    get { return _upi; } 
			set 
			{
			    _upi = value;
			}
        }

		private String _userMail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_mail" )]		
		public String UserMail 
		{ 
		    get { return _userMail; } 
			set 
			{
			    _userMail = value;
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

		private String _role;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="role" )]		
		public String Role 
		{ 
		    get { return _role; } 
			set 
			{
			    _role = value;
			}
        }

		private String _roleDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 1000, ColumnName ="role_description" )]		
		public String RoleDescription 
		{ 
		    get { return _roleDescription; } 
			set 
			{
			    _roleDescription = value;
			}
        }

		private String _title;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="title" )]		
		public String Title 
		{ 
		    get { return _title; } 
			set 
			{
			    _title = value;
			}
        }

		private String _jobDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 256, ColumnName ="job_description" )]		
		public String JobDescription 
		{ 
		    get { return _jobDescription; } 
			set 
			{
			    _jobDescription = value;
			}
        }

		private DateTime? _lastLoginAttempt;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="last_login_attempt" )]		
		public DateTime? LastLoginAttempt 
		{ 
		    get { return _lastLoginAttempt; } 
			set 
			{
			    _lastLoginAttempt = value;
			}
        }

		private Boolean _ouIsActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="ou_is_active" )]		
		public Boolean OuIsActive 
		{ 
		    get { return _ouIsActive; } 
			set 
			{
			    _ouIsActive = value;
			}
        }

		private Boolean _ouParentIsActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="ou_parent_is_active" )]		
		public Boolean OuParentIsActive 
		{ 
		    get { return _ouParentIsActive; } 
			set 
			{
			    _ouParentIsActive = value;
			}
        }

		private String _ouParentBusinessUnitId;
		[DataMember]
		[SqlField(DbType.AnsiString, 101, IsReadOnly = true, ColumnName ="ou_parent_business_unit_id" )]		
		public String OuParentBusinessUnitId 
		{ 
		    get { return _ouParentBusinessUnitId; } 
			set 
			{
			    _ouParentBusinessUnitId = value;
			}
        }

		private Boolean _isOuAllergan;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_ou_allergan" )]		
		public Boolean IsOuAllergan 
		{ 
		    get { return _isOuAllergan; } 
			set 
			{
			    _isOuAllergan = value;
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

		public const string AreaExportProjectionColumnList = "[ou_id], [ou_area_id], [ou_parent_id], [ou_parent_name], [ou_name], [ou_type_id], [ou_type], [has_advisor], [currency], [user_id], [user_name], [login_name], [upi], [user_mail], [is_active], [role], [role_description], [title], [job_description], [last_login_attempt]";
		public const string ExportProjectionColumnList = "[ou_id], [ou_is_active], [ou_parent_id], [ou_parent_is_active], [ou_parent_name], [ou_parent_business_unit_id], [ou_name], [ou_type_id], [is_ou_allergan], [ou_type], [has_advisor], [currency], [user_id], [user_name], [login_name], [upi], [user_mail], [is_active], [role_id], [role], [role_description], [title], [job_description], [last_login_attempt]";

	}

	public partial class UserRoleOrganizationalUnitRepository : Repository<UserRoleOrganizationalUnit> 
	{
		public UserRoleOrganizationalUnitRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class UserRoleOrganizationalUnitFields
	{
		public const string OuId = "OuId";
		public const string OuAreaId = "OuAreaId";
		public const string OuParentId = "OuParentId";
		public const string OuParentName = "OuParentName";
		public const string OuName = "OuName";
		public const string OuTypeId = "OuTypeId";
		public const string OuType = "OuType";
		public const string HasAdvisor = "HasAdvisor";
		public const string Currency = "Currency";
		public const string UserId = "UserId";
		public const string UserName = "UserName";
		public const string LoginName = "LoginName";
		public const string Upi = "Upi";
		public const string UserMail = "UserMail";
		public const string IsActive = "IsActive";
		public const string Role = "Role";
		public const string RoleDescription = "RoleDescription";
		public const string Title = "Title";
		public const string JobDescription = "JobDescription";
		public const string LastLoginAttempt = "LastLoginAttempt";
		public const string OuIsActive = "OuIsActive";
		public const string OuParentIsActive = "OuParentIsActive";
		public const string OuParentBusinessUnitId = "OuParentBusinessUnitId";
		public const string IsOuAllergan = "IsOuAllergan";
		public const string RoleId = "RoleId";
	}

	public static partial class UserRoleOrganizationalUnitProjections
	{
		public const string AreaExport = "AreaExport";
		public const string Export = "Export";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="user_criteria_parameters")]
	public partial class UserCriteriaParameter
	{
		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_criteria_parameters" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private String _userCriteriaField;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_criteria_field", BaseColumnName ="user_criteria_field", BaseTableName = "user_criteria_parameters" )]		
		public String UserCriteriaField 
		{ 
		    get { return _userCriteriaField; } 
			set 
			{
			    _userCriteriaField = value;
			}
        }

		private Int32 _userCriteriaNumItems;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="user_criteria_num_items", BaseColumnName ="user_criteria_num_items", BaseTableName = "user_criteria_parameters" )]		
		public Int32 UserCriteriaNumItems 
		{ 
		    get { return _userCriteriaNumItems; } 
			set 
			{
			    _userCriteriaNumItems = value;
			}
        }

		private Boolean _userCriteriaIsOrderByDesc;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="user_criteria_is_order_by_desc", BaseColumnName ="user_criteria_is_order_by_desc", BaseTableName = "user_criteria_parameters" )]		
		public Boolean UserCriteriaIsOrderByDesc 
		{ 
		    get { return _userCriteriaIsOrderByDesc; } 
			set 
			{
			    _userCriteriaIsOrderByDesc = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[user_id], [user_criteria_field], [user_criteria_num_items], [user_criteria_is_order_by_desc]";

	}

	public partial class UserCriteriaParameterRepository : Repository<UserCriteriaParameter> 
	{
		public UserCriteriaParameterRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public UserCriteriaParameter Get(string projectionName, Int32 userId)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public UserCriteriaParameter Get(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projectionName, userId, fetchMode);
		}

		public UserCriteriaParameter Get(Projection projection, Int32 userId)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projection, userId, FetchMode.UseIdentityMap);
		}

		public UserCriteriaParameter Get(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projection, userId, fetchMode);
		}

		public UserCriteriaParameter Get(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projectionName, userId, fields);
		}

		public UserCriteriaParameter Get(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserCriteriaParameter>)this).Get(projection, userId, fields);
		}

		public bool Delete(Int32 userId)
		{
			var entity = new UserCriteriaParameter { UserId = userId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(string projectionName, Int32 userId)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projectionName, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(string projectionName, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projectionName, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(Projection projection, Int32 userId)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projection, userId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(Projection projection, Int32 userId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projection, userId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(string projectionName, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projectionName, userId, fields);
		}

		public System.Threading.Tasks.Task<UserCriteriaParameter> GetAsync(Projection projection, Int32 userId, params string[] fields)
		{
			return ((IRepository<UserCriteriaParameter>)this).GetAsync(projection, userId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 userId)
		{
			var entity = new UserCriteriaParameter { UserId = userId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class UserCriteriaParameterFields
	{
		public const string UserId = "UserId";
		public const string UserCriteriaField = "UserCriteriaField";
		public const string UserCriteriaNumItems = "UserCriteriaNumItems";
		public const string UserCriteriaIsOrderByDesc = "UserCriteriaIsOrderByDesc";
	}

	public static partial class UserCriteriaParameterProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="entity_hierarchy")]
	public partial class Entity
	{
		private Int32 _entityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "entity_hierarchy_entity_id_seq", ColumnName ="entity_id", BaseColumnName ="entity_id", BaseTableName = "entity_hierarchy" )]		
		public Int32 EntityId 
		{ 
		    get { return _entityId; } 
			set 
			{
			    _entityId = value;
			}
        }

		private EntityTypeId _entityTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="entity_type_id", BaseColumnName ="entity_type_id", BaseTableName = "entity_hierarchy" )]		
		public EntityTypeId EntityTypeId 
		{ 
		    get { return _entityTypeId; } 
			set 
			{
			    _entityTypeId = value;
			}
        }

		private Int32? _parentEntityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="parent_entity_id", BaseColumnName ="parent_entity_id", BaseTableName = "entity_hierarchy" )]		
		public Int32? ParentEntityId 
		{ 
		    get { return _parentEntityId; } 
			set 
			{
			    _parentEntityId = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[entity_id], [entity_type_id], [parent_entity_id]";

	}

	public partial class EntityRepository : Repository<Entity> 
	{
		public EntityRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Entity Get(string projectionName, Int32 entityId)
		{
			return ((IRepository<Entity>)this).Get(projectionName, entityId, FetchMode.UseIdentityMap);
		}

		public Entity Get(string projectionName, Int32 entityId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Entity>)this).Get(projectionName, entityId, fetchMode);
		}

		public Entity Get(Projection projection, Int32 entityId)
		{
			return ((IRepository<Entity>)this).Get(projection, entityId, FetchMode.UseIdentityMap);
		}

		public Entity Get(Projection projection, Int32 entityId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Entity>)this).Get(projection, entityId, fetchMode);
		}

		public Entity Get(string projectionName, Int32 entityId, params string[] fields)
		{
			return ((IRepository<Entity>)this).Get(projectionName, entityId, fields);
		}

		public Entity Get(Projection projection, Int32 entityId, params string[] fields)
		{
			return ((IRepository<Entity>)this).Get(projection, entityId, fields);
		}

		public bool Delete(Int32 entityId)
		{
			var entity = new Entity { EntityId = entityId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<Entity> GetAsync(string projectionName, Int32 entityId)
		{
			return ((IRepository<Entity>)this).GetAsync(projectionName, entityId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Entity> GetAsync(string projectionName, Int32 entityId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Entity>)this).GetAsync(projectionName, entityId, fetchMode);
		}

		public System.Threading.Tasks.Task<Entity> GetAsync(Projection projection, Int32 entityId)
		{
			return ((IRepository<Entity>)this).GetAsync(projection, entityId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Entity> GetAsync(Projection projection, Int32 entityId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Entity>)this).GetAsync(projection, entityId, fetchMode);
		}

		public System.Threading.Tasks.Task<Entity> GetAsync(string projectionName, Int32 entityId, params string[] fields)
		{
			return ((IRepository<Entity>)this).GetAsync(projectionName, entityId, fields);
		}

		public System.Threading.Tasks.Task<Entity> GetAsync(Projection projection, Int32 entityId, params string[] fields)
		{
			return ((IRepository<Entity>)this).GetAsync(projection, entityId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 entityId)
		{
			var entity = new Entity { EntityId = entityId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class EntityFields
	{
		public const string EntityId = "EntityId";
		public const string EntityTypeId = "EntityTypeId";
		public const string ParentEntityId = "ParentEntityId";
	}

	public static partial class EntityProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="entity_types")]
	public partial class EntityType
	{
		private EntityTypeId _entityTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "entity_types_entity_type_id_seq", IsAutoincrement=true, IsReadOnly = true, ColumnName ="entity_type_id", BaseColumnName ="entity_type_id", BaseTableName = "entity_types" )]		
		public EntityTypeId EntityTypeId 
		{ 
		    get { return _entityTypeId; } 
			set 
			{
			    _entityTypeId = value;
			}
        }

		private String _entityTypeName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="entity_type_name", BaseColumnName ="entity_type_name", BaseTableName = "entity_types" )]		
		public String EntityTypeName 
		{ 
		    get { return _entityTypeName; } 
			set 
			{
			    _entityTypeName = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[entity_type_id], [entity_type_name]";

	}

	public partial class EntityTypeRepository : Repository<EntityType> 
	{
		public EntityTypeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public EntityType Get(string projectionName, EntityTypeId entityTypeId)
		{
			return ((IRepository<EntityType>)this).Get(projectionName, entityTypeId, FetchMode.UseIdentityMap);
		}

		public EntityType Get(string projectionName, EntityTypeId entityTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<EntityType>)this).Get(projectionName, entityTypeId, fetchMode);
		}

		public EntityType Get(Projection projection, EntityTypeId entityTypeId)
		{
			return ((IRepository<EntityType>)this).Get(projection, entityTypeId, FetchMode.UseIdentityMap);
		}

		public EntityType Get(Projection projection, EntityTypeId entityTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<EntityType>)this).Get(projection, entityTypeId, fetchMode);
		}

		public EntityType Get(string projectionName, EntityTypeId entityTypeId, params string[] fields)
		{
			return ((IRepository<EntityType>)this).Get(projectionName, entityTypeId, fields);
		}

		public EntityType Get(Projection projection, EntityTypeId entityTypeId, params string[] fields)
		{
			return ((IRepository<EntityType>)this).Get(projection, entityTypeId, fields);
		}

		public bool Delete(EntityTypeId entityTypeId)
		{
			var entity = new EntityType { EntityTypeId = entityTypeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<EntityType> GetAsync(string projectionName, EntityTypeId entityTypeId)
		{
			return ((IRepository<EntityType>)this).GetAsync(projectionName, entityTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<EntityType> GetAsync(string projectionName, EntityTypeId entityTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<EntityType>)this).GetAsync(projectionName, entityTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<EntityType> GetAsync(Projection projection, EntityTypeId entityTypeId)
		{
			return ((IRepository<EntityType>)this).GetAsync(projection, entityTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<EntityType> GetAsync(Projection projection, EntityTypeId entityTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<EntityType>)this).GetAsync(projection, entityTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<EntityType> GetAsync(string projectionName, EntityTypeId entityTypeId, params string[] fields)
		{
			return ((IRepository<EntityType>)this).GetAsync(projectionName, entityTypeId, fields);
		}

		public System.Threading.Tasks.Task<EntityType> GetAsync(Projection projection, EntityTypeId entityTypeId, params string[] fields)
		{
			return ((IRepository<EntityType>)this).GetAsync(projection, entityTypeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(EntityTypeId entityTypeId)
		{
			var entity = new EntityType { EntityTypeId = entityTypeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class EntityTypeFields
	{
		public const string EntityTypeId = "EntityTypeId";
		public const string EntityTypeName = "EntityTypeName";
	}

	public static partial class EntityTypeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="entity_ancestors")]
	public partial class EntityAncestors
	{
		private Int32 _entityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="entity_id", BaseColumnName ="entity_id", BaseTableName = "entity_ancestors" )]		
		public Int32 EntityId 
		{ 
		    get { return _entityId; } 
			set 
			{
			    _entityId = value;
			}
        }

		private Int32 _ancestorEntityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ancestor_entity_id", BaseColumnName ="ancestor_entity_id", BaseTableName = "entity_ancestors" )]		
		public Int32 AncestorEntityId 
		{ 
		    get { return _ancestorEntityId; } 
			set 
			{
			    _ancestorEntityId = value;
			}
        }

		private Byte _level;
		[DataMember]
		[SqlField(DbType.Byte, 1, Precision = 3, ColumnName ="level", BaseColumnName ="level", BaseTableName = "entity_ancestors" )]		
		public Byte Level 
		{ 
		    get { return _level; } 
			set 
			{
			    _level = value;
			}
        }

		private Byte _reverseLevel;
		[DataMember]
		[SqlField(DbType.Byte, 1, Precision = 3, ColumnName ="reverse_level", BaseColumnName ="reverse_level", BaseTableName = "entity_ancestors" )]		
		public Byte ReverseLevel 
		{ 
		    get { return _reverseLevel; } 
			set 
			{
			    _reverseLevel = value;
			}
        }

		private EntityTypeId _entityTypeId;
		[DataMember]
		[SqlField(DbType.Int16, 2, Precision = 5, ColumnName ="entity_type_id", BaseColumnName ="entity_type_id", BaseTableName = "entity_ancestors" )]		
		public EntityTypeId EntityTypeId 
		{ 
		    get { return _entityTypeId; } 
			set 
			{
			    _entityTypeId = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[entity_id], [ancestor_entity_id], [level], [reverse_level], [entity_type_id]";

	}

	public partial class EntityAncestorsRepository : Repository<EntityAncestors> 
	{
		public EntityAncestorsRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class EntityAncestorsFields
	{
		public const string EntityId = "EntityId";
		public const string AncestorEntityId = "AncestorEntityId";
		public const string Level = "Level";
		public const string ReverseLevel = "ReverseLevel";
		public const string EntityTypeId = "EntityTypeId";
	}

	public static partial class EntityAncestorsProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_units")]
	[ParentPropertyName("OuParentId")]
	public partial class OrganizationalUnit
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_units" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name", BaseColumnName ="ou_name", BaseTableName = "organizational_units" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private String _ouDescription;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="ou_description", BaseColumnName ="ou_description", BaseTableName = "organizational_units" )]		
		public String OuDescription 
		{ 
		    get { return _ouDescription; } 
			set 
			{
			    _ouDescription = value;
			}
        }

		private String _ouCode;
		[DataMember]
		[SqlField(DbType.String, 30, ColumnName ="ou_code", BaseColumnName ="ou_code", BaseTableName = "organizational_units" )]		
		public String OuCode 
		{ 
		    get { return _ouCode; } 
			set 
			{
			    _ouCode = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_units" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_units" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_units" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_units" )]		
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
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "organizational_units" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private Int32? _ouParentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_parent_id", BaseColumnName ="ou_parent_id", BaseTableName = "organizational_units" )]		
		public Int32? OuParentId 
		{ 
		    get { return _ouParentId; } 
			set 
			{
			    _ouParentId = value;
			}
        }

		private Int32 _ouTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_type_id", BaseColumnName ="ou_type_id", BaseTableName = "organizational_units" )]		
		public Int32 OuTypeId 
		{ 
		    get { return _ouTypeId; } 
			set 
			{
			    _ouTypeId = value;
			}
        }

		private Boolean _hasAdvisor;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_advisor", BaseColumnName ="has_advisor", BaseTableName = "organizational_units" )]		
		public Boolean HasAdvisor 
		{ 
		    get { return _hasAdvisor; } 
			set 
			{
			    _hasAdvisor = value;
			}
        }

		private String _currencySymbol;
		[DataMember]
		[SqlField(DbType.String, 5, ColumnName ="currency_symbol", BaseColumnName ="currency_symbol", BaseTableName = "organizational_units" )]		
		public String CurrencySymbol 
		{ 
		    get { return _currencySymbol; } 
			set 
			{
			    _currencySymbol = value;
			}
        }

		private Boolean? _rightSymbol;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="right_symbol", BaseColumnName ="right_symbol", BaseTableName = "organizational_units" )]		
		public Boolean? RightSymbol 
		{ 
		    get { return _rightSymbol; } 
			set 
			{
			    _rightSymbol = value;
			}
        }

		private Int32? _currencyId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="currency_id", BaseColumnName ="currency_id", BaseTableName = "organizational_units" )]		
		public Int32? CurrencyId 
		{ 
		    get { return _currencyId; } 
			set 
			{
			    _currencyId = value;
			}
        }

		private String _ouCountryCode;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 2, ColumnName ="ou_country_code", BaseColumnName ="ou_country_code", BaseTableName = "organizational_units" )]		
		public String OuCountryCode 
		{ 
		    get { return _ouCountryCode; } 
			set 
			{
			    _ouCountryCode = value;
			}
        }

		private Int32? _departmentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="department_id", BaseColumnName ="department_id", BaseTableName = "organizational_units" )]		
		public Int32? DepartmentId 
		{ 
		    get { return _departmentId; } 
			set 
			{
			    _departmentId = value;
			}
        }

		private Boolean _hasOdsSearch;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_ods_search", BaseColumnName ="has_ods_search", BaseTableName = "organizational_units" )]		
		public Boolean HasOdsSearch 
		{ 
		    get { return _hasOdsSearch; } 
			set 
			{
			    _hasOdsSearch = value;
			}
        }

		private Boolean _hcoOds;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="hco_ods", BaseColumnName ="hco_ods", BaseTableName = "organizational_units" )]		
		public Boolean HcoOds 
		{ 
		    get { return _hcoOds; } 
			set 
			{
			    _hcoOds = value;
			}
        }

		private Boolean _hasLinkZinc;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_link_zinc", BaseColumnName ="has_link_zinc", BaseTableName = "organizational_units" )]		
		public Boolean HasLinkZinc 
		{ 
		    get { return _hasLinkZinc; } 
			set 
			{
			    _hasLinkZinc = value;
			}
        }

		private Boolean _allowApprovalPrivateOrganization;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_approval_private_organization", BaseColumnName ="allow_approval_private_organization", BaseTableName = "organizational_units" )]		
		public Boolean AllowApprovalPrivateOrganization 
		{ 
		    get { return _allowApprovalPrivateOrganization; } 
			set 
			{
			    _allowApprovalPrivateOrganization = value;
			}
        }

		private Boolean _showThirdPartyLogisticsVendorTab;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="show_third_party_logistics_vendor_tab", BaseColumnName ="show_third_party_logistics_vendor_tab", BaseTableName = "organizational_units" )]		
		public Boolean ShowThirdPartyLogisticsVendorTab 
		{ 
		    get { return _showThirdPartyLogisticsVendorTab; } 
			set 
			{
			    _showThirdPartyLogisticsVendorTab = value;
			}
        }

		private Int32? _inputCharactersRemaining;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="input_characters_remaining", BaseColumnName ="input_characters_remaining", BaseTableName = "organizational_units" )]		
		public Int32? InputCharactersRemaining 
		{ 
		    get { return _inputCharactersRemaining; } 
			set 
			{
			    _inputCharactersRemaining = value;
			}
        }

		private Int32? _recipientEntityTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="recipient_entity_type_id", BaseColumnName ="recipient_entity_type_id", BaseTableName = "organizational_units" )]		
		public Int32? RecipientEntityTypeId 
		{ 
		    get { return _recipientEntityTypeId; } 
			set 
			{
			    _recipientEntityTypeId = value;
			}
        }

		private Boolean _allowHcoInProfessionalServices;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_hco_in_professional_services", BaseColumnName ="allow_hco_in_professional_services", BaseTableName = "organizational_units" )]		
		public Boolean AllowHcoInProfessionalServices 
		{ 
		    get { return _allowHcoInProfessionalServices; } 
			set 
			{
			    _allowHcoInProfessionalServices = value;
			}
        }

		private Boolean? _allowChangeAdvisorToDecisionMaker;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_change_advisor_to_decision_maker", BaseColumnName ="allow_change_advisor_to_decision_maker", BaseTableName = "organizational_units" )]		
		public Boolean? AllowChangeAdvisorToDecisionMaker 
		{ 
		    get { return _allowChangeAdvisorToDecisionMaker; } 
			set 
			{
			    _allowChangeAdvisorToDecisionMaker = value;
			}
        }

		private Boolean _allowSupportGroupSubmitForms;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_support_group_submit_forms", BaseColumnName ="allow_support_group_submit_forms", BaseTableName = "organizational_units" )]		
		public Boolean AllowSupportGroupSubmitForms 
		{ 
		    get { return _allowSupportGroupSubmitForms; } 
			set 
			{
			    _allowSupportGroupSubmitForms = value;
			}
        }

		private Boolean _blockBudgetReconciliation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="block_budget_reconciliation", BaseColumnName ="block_budget_reconciliation", BaseTableName = "organizational_units" )]		
		public Boolean BlockBudgetReconciliation 
		{ 
		    get { return _blockBudgetReconciliation; } 
			set 
			{
			    _blockBudgetReconciliation = value;
			}
        }

		private Boolean _allowSelectionAdvisorsDecisionMaker;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_selection_advisors_decision_maker", BaseColumnName ="allow_selection_advisors_decision_maker", BaseTableName = "organizational_units" )]		
		public Boolean AllowSelectionAdvisorsDecisionMaker 
		{ 
		    get { return _allowSelectionAdvisorsDecisionMaker; } 
			set 
			{
			    _allowSelectionAdvisorsDecisionMaker = value;
			}
        }

		private Boolean _removeAdvisorInSendBackInitiator;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="remove_advisor_in_send_back_initiator", BaseColumnName ="remove_advisor_in_send_back_initiator", BaseTableName = "organizational_units" )]		
		public Boolean RemoveAdvisorInSendBackInitiator 
		{ 
		    get { return _removeAdvisorInSendBackInitiator; } 
			set 
			{
			    _removeAdvisorInSendBackInitiator = value;
			}
        }

		private Boolean _countryWithCertification;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="country_with_certification", BaseColumnName ="country_with_certification", BaseTableName = "organizational_units" )]		
		public Boolean CountryWithCertification 
		{ 
		    get { return _countryWithCertification; } 
			set 
			{
			    _countryWithCertification = value;
			}
        }

		private Boolean _rolesSyncWithAd;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="roles_sync_with_ad", BaseColumnName ="roles_sync_with_ad", BaseTableName = "organizational_units" )]		
		public Boolean RolesSyncWithAd 
		{ 
		    get { return _rolesSyncWithAd; } 
			set 
			{
			    _rolesSyncWithAd = value;
			}
        }

		private String _ntGroupName;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="nt_group_name", BaseColumnName ="nt_group_name", BaseTableName = "organizational_units" )]		
		public String NtGroupName 
		{ 
		    get { return _ntGroupName; } 
			set 
			{
			    _ntGroupName = value;
			}
        }

		private Boolean? _onlyHasApprovalPhase;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="only_has_approval_phase", BaseColumnName ="only_has_approval_phase", BaseTableName = "organizational_units" )]		
		public Boolean? OnlyHasApprovalPhase 
		{ 
		    get { return _onlyHasApprovalPhase; } 
			set 
			{
			    _onlyHasApprovalPhase = value;
			}
        }

		private Boolean _wbsSelectable;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="wbs_selectable", BaseColumnName ="wbs_selectable", BaseTableName = "organizational_units" )]		
		public Boolean WbsSelectable 
		{ 
		    get { return _wbsSelectable; } 
			set 
			{
			    _wbsSelectable = value;
			}
        }

		private Boolean _hasAttendeesExtended;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_attendees_extended", BaseColumnName ="has_attendees_extended", BaseTableName = "organizational_units" )]		
		public Boolean HasAttendeesExtended 
		{ 
		    get { return _hasAttendeesExtended; } 
			set 
			{
			    _hasAttendeesExtended = value;
			}
        }

		private Boolean _hasSolicitedUnsolicited;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_solicited_unsolicited", BaseColumnName ="has_solicited_unsolicited", BaseTableName = "organizational_units" )]		
		public Boolean HasSolicitedUnsolicited 
		{ 
		    get { return _hasSolicitedUnsolicited; } 
			set 
			{
			    _hasSolicitedUnsolicited = value;
			}
        }

		private Boolean _hasProductProjectActivity;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_product_project_activity", BaseColumnName ="has_product_project_activity", BaseTableName = "organizational_units" )]		
		public Boolean HasProductProjectActivity 
		{ 
		    get { return _hasProductProjectActivity; } 
			set 
			{
			    _hasProductProjectActivity = value;
			}
        }

		private Boolean _hasSearchSapProvider;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_search_sap_provider", BaseColumnName ="has_search_sap_provider", BaseTableName = "organizational_units" )]		
		public Boolean HasSearchSapProvider 
		{ 
		    get { return _hasSearchSapProvider; } 
			set 
			{
			    _hasSearchSapProvider = value;
			}
        }

		private Boolean _infieldActivity;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="infield_activity", BaseColumnName ="infield_activity", BaseTableName = "organizational_units" )]		
		public Boolean InfieldActivity 
		{ 
		    get { return _infieldActivity; } 
			set 
			{
			    _infieldActivity = value;
			}
        }

		private Boolean _hasInternalOrders;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_internal_orders", BaseColumnName ="has_internal_orders", BaseTableName = "organizational_units" )]		
		public Boolean HasInternalOrders 
		{ 
		    get { return _hasInternalOrders; } 
			set 
			{
			    _hasInternalOrders = value;
			}
        }

		private Boolean _allGenerateContract;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="all_generate_contract", BaseColumnName ="all_generate_contract", BaseTableName = "organizational_units" )]		
		public Boolean AllGenerateContract 
		{ 
		    get { return _allGenerateContract; } 
			set 
			{
			    _allGenerateContract = value;
			}
        }

		private Boolean _hasRecipientsStatusTracking;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_recipients_status_tracking", BaseColumnName ="has_recipients_status_tracking", BaseTableName = "organizational_units" )]		
		public Boolean HasRecipientsStatusTracking 
		{ 
		    get { return _hasRecipientsStatusTracking; } 
			set 
			{
			    _hasRecipientsStatusTracking = value;
			}
        }

		private Boolean _hasSignedContracts;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_signed_contracts", BaseColumnName ="has_signed_contracts", BaseTableName = "organizational_units" )]		
		public Boolean HasSignedContracts 
		{ 
		    get { return _hasSignedContracts; } 
			set 
			{
			    _hasSignedContracts = value;
			}
        }

		private Boolean _activateEventsModule;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="activate_events_module", BaseColumnName ="activate_events_module", BaseTableName = "organizational_units" )]		
		public Boolean ActivateEventsModule 
		{ 
		    get { return _activateEventsModule; } 
			set 
			{
			    _activateEventsModule = value;
			}
        }

		private Boolean _allowSupportGroupToCancelForms;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_support_group_to_cancel_forms", BaseColumnName ="allow_support_group_to_cancel_forms", BaseTableName = "organizational_units" )]		
		public Boolean AllowSupportGroupToCancelForms 
		{ 
		    get { return _allowSupportGroupToCancelForms; } 
			set 
			{
			    _allowSupportGroupToCancelForms = value;
			}
        }

		private Boolean _selectLoadModeRecipientsDetails;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="select_load_mode_recipients_details", BaseColumnName ="select_load_mode_recipients_details", BaseTableName = "organizational_units" )]		
		public Boolean SelectLoadModeRecipientsDetails 
		{ 
		    get { return _selectLoadModeRecipientsDetails; } 
			set 
			{
			    _selectLoadModeRecipientsDetails = value;
			}
        }

		private Boolean _isOdsLocal;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_ods_local", BaseColumnName ="is_ods_local", BaseTableName = "organizational_units" )]		
		public Boolean IsOdsLocal 
		{ 
		    get { return _isOdsLocal; } 
			set 
			{
			    _isOdsLocal = value;
			}
        }

		private Boolean _isEnableDisableAutomaticContractingTool;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_enable_disable_automatic_contracting_tool", BaseColumnName ="is_enable_disable_automatic_contracting_tool", BaseTableName = "organizational_units" )]		
		public Boolean IsEnableDisableAutomaticContractingTool 
		{ 
		    get { return _isEnableDisableAutomaticContractingTool; } 
			set 
			{
			    _isEnableDisableAutomaticContractingTool = value;
			}
        }

		private Boolean _additionalApprovalBeforeCloseout;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="additional_approval_before_closeout", BaseColumnName ="additional_approval_before_closeout", BaseTableName = "organizational_units" )]		
		public Boolean AdditionalApprovalBeforeCloseout 
		{ 
		    get { return _additionalApprovalBeforeCloseout; } 
			set 
			{
			    _additionalApprovalBeforeCloseout = value;
			}
        }

		private Boolean _isSapLocal;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_sap_local", BaseColumnName ="is_sap_local", BaseTableName = "organizational_units" )]		
		public Boolean IsSapLocal 
		{ 
		    get { return _isSapLocal; } 
			set 
			{
			    _isSapLocal = value;
			}
        }

		private Boolean _hasLogisticalArrangementsExtended;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_logistical_arrangements_extended", BaseColumnName ="has_logistical_arrangements_extended", BaseTableName = "organizational_units" )]		
		public Boolean HasLogisticalArrangementsExtended 
		{ 
		    get { return _hasLogisticalArrangementsExtended; } 
			set 
			{
			    _hasLogisticalArrangementsExtended = value;
			}
        }

		private Int32? _additionalApprovalBeforeCloseoutRolId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="additional_approval_before_closeout_rol_id", BaseColumnName ="additional_approval_before_closeout_rol_id", BaseTableName = "organizational_units" )]		
		public Int32? AdditionalApprovalBeforeCloseoutRolId 
		{ 
		    get { return _additionalApprovalBeforeCloseoutRolId; } 
			set 
			{
			    _additionalApprovalBeforeCloseoutRolId = value;
			}
        }

		private Boolean _isOuAllergan;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_ou_allergan", BaseColumnName ="is_ou_allergan", BaseTableName = "organizational_units" )]		
		public Boolean IsOuAllergan 
		{ 
		    get { return _isOuAllergan; } 
			set 
			{
			    _isOuAllergan = value;
			}
        }

		private Boolean _isCrossBorderHost;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_cross_border_host", BaseColumnName ="is_cross_border_host", BaseTableName = "organizational_units" )]		
		public Boolean IsCrossBorderHost 
		{ 
		    get { return _isCrossBorderHost; } 
			set 
			{
			    _isCrossBorderHost = value;
			}
        }

		private Boolean _isCrossBorderHome;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_cross_border_home", BaseColumnName ="is_cross_border_home", BaseTableName = "organizational_units" )]		
		public Boolean IsCrossBorderHome 
		{ 
		    get { return _isCrossBorderHome; } 
			set 
			{
			    _isCrossBorderHome = value;
			}
        }

		private Boolean _isCrossBorder;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_cross_border", BaseColumnName ="is_cross_border", BaseTableName = "organizational_units" )]		
		public Boolean IsCrossBorder 
		{ 
		    get { return _isCrossBorder; } 
			set 
			{
			    _isCrossBorder = value;
			}
        }

		private Boolean _hasMassiveUploadAssistants;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_massive_upload_assistants", BaseColumnName ="has_massive_upload_assistants", BaseTableName = "organizational_units" )]		
		public Boolean HasMassiveUploadAssistants 
		{ 
		    get { return _hasMassiveUploadAssistants; } 
			set 
			{
			    _hasMassiveUploadAssistants = value;
			}
        }

		private Boolean _hasInvitationLettersAssistants;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_invitation_letters_assistants", BaseColumnName ="has_invitation_letters_assistants", BaseTableName = "organizational_units" )]		
		public Boolean HasInvitationLettersAssistants 
		{ 
		    get { return _hasInvitationLettersAssistants; } 
			set 
			{
			    _hasInvitationLettersAssistants = value;
			}
        }

		private Boolean _hasPsExtendedGeneric;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_ps_extended_generic", BaseColumnName ="has_ps_extended_generic", BaseTableName = "organizational_units" )]		
		public Boolean HasPsExtendedGeneric 
		{ 
		    get { return _hasPsExtendedGeneric; } 
			set 
			{
			    _hasPsExtendedGeneric = value;
			}
        }

		private Boolean _hasLogisticalReconciliation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_logistical_reconciliation", BaseColumnName ="has_logistical_reconciliation", BaseTableName = "organizational_units" )]		
		public Boolean HasLogisticalReconciliation 
		{ 
		    get { return _hasLogisticalReconciliation; } 
			set 
			{
			    _hasLogisticalReconciliation = value;
			}
        }

		private Boolean _hasFinancialData;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_financial_data", BaseColumnName ="has_financial_data", BaseTableName = "organizational_units" )]		
		public Boolean HasFinancialData 
		{ 
		    get { return _hasFinancialData; } 
			set 
			{
			    _hasFinancialData = value;
			}
        }

		private Boolean _useMdm;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="use_mdm", BaseColumnName ="use_mdm", BaseTableName = "organizational_units" )]		
		public Boolean UseMdm 
		{ 
		    get { return _useMdm; } 
			set 
			{
			    _useMdm = value;
			}
        }

		private Boolean _hasAllerganContractTemplate;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_allergan_contract_template", BaseColumnName ="has_allergan_contract_template", BaseTableName = "organizational_units" )]		
		public Boolean HasAllerganContractTemplate 
		{ 
		    get { return _hasAllerganContractTemplate; } 
			set 
			{
			    _hasAllerganContractTemplate = value;
			}
        }

		private Int32? _upLevel;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="UpLevel" )]		
		public Int32? UpLevel 
		{ 
		    get { return _upLevel; } 
			set 
			{
			    _upLevel = value;
			}
        }

		private String _path;
		[DataMember]
		[SqlField(DbType.AnsiString, 8000, ColumnName ="Path" )]		
		public String Path 
		{ 
		    get { return _path; } 
			set 
			{
			    _path = value;
			}
        }

		private Int32? _ouCountryId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_country_id" )]		
		public Int32? OuCountryId 
		{ 
		    get { return _ouCountryId; } 
			set 
			{
			    _ouCountryId = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [ou_name], [ou_description], [ou_code], [created_date], [created_by], [modified_date], [modified_by], [is_active], [ou_parent_id], [ou_type_id], [has_advisor], [currency_symbol], [right_symbol], [currency_id], [ou_country_code], [department_id], [has_ods_search], [hco_ods], [has_link_zinc], [allow_approval_private_organization], [show_third_party_logistics_vendor_tab], [input_characters_remaining], [recipient_entity_type_id], [allow_hco_in_professional_services], [allow_change_advisor_to_decision_maker], [allow_support_group_submit_forms], [block_budget_reconciliation], [allow_selection_advisors_decision_maker], [remove_advisor_in_send_back_initiator], [country_with_certification], [roles_sync_with_ad], [nt_group_name], [only_has_approval_phase], [wbs_selectable], [has_attendees_extended], [has_solicited_unsolicited], [has_product_project_activity], [has_search_sap_provider], [infield_activity], [has_internal_orders], [all_generate_contract], [has_recipients_status_tracking], [has_signed_contracts], [activate_events_module], [allow_support_group_to_cancel_forms], [select_load_mode_recipients_details], [is_ods_local], [is_enable_disable_automatic_contracting_tool], [additional_approval_before_closeout], [is_sap_local], [has_logistical_arrangements_extended], [additional_approval_before_closeout_rol_id], [is_ou_allergan], [is_cross_border_host], [is_cross_border_home], [is_cross_border], [has_massive_upload_assistants], [has_invitation_letters_assistants], [has_ps_extended_generic], [has_logistical_reconciliation], [has_financial_data], [use_mdm], [has_allergan_contract_template]";
		public const string FullHierarchyProjectionColumnList = "[ou_id], [ou_name], [ou_description], [ou_code], [created_date], [created_by], [modified_date], [modified_by], [is_active], [ou_parent_id], [ou_type_id], [has_advisor], [currency_symbol], [right_symbol], [input_characters_remaining], [currency_id], [ou_country_code], [department_id], [has_ods_search], [hco_ods], [has_link_zinc], [allow_approval_private_organization], [allow_hco_in_professional_services], [show_third_party_logistics_vendor_tab], [recipient_entity_type_id], [allow_change_advisor_to_decision_maker], [allow_support_group_submit_forms], [block_budget_reconciliation], [allow_selection_advisors_decision_maker], [remove_advisor_in_send_back_initiator], [country_with_certification], [roles_sync_with_ad], [nt_group_name], [only_has_approval_phase], [wbs_selectable], [has_attendees_extended], [has_solicited_unsolicited], [has_product_project_activity], [has_search_sap_provider], [infield_activity], [has_internal_orders], [all_generate_contract], [has_recipients_status_tracking], [has_signed_contracts], [activate_events_module], [allow_support_group_to_cancel_forms], [select_load_mode_recipients_details], [is_ods_local], [is_enable_disable_automatic_contracting_tool], [additional_approval_before_closeout], [is_sap_local], [UpLevel], [Path], [ou_country_id], [has_logistical_arrangements_extended], [additional_approval_before_closeout_rol_id], [is_ou_allergan], [is_cross_border_host], [is_cross_border_home], [is_cross_border], [has_massive_upload_assistants], [has_invitation_letters_assistants], [has_ps_extended_generic], [has_logistical_reconciliation], [has_financial_data], [use_mdm], [has_allergan_contract_template]";

	}

	public partial class OrganizationalUnitRepository : Repository<OrganizationalUnit> 
	{
		public OrganizationalUnitRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnit Get(string projectionName, Int32 ouId)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projectionName, ouId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnit Get(string projectionName, Int32 ouId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projectionName, ouId, fetchMode);
		}

		public OrganizationalUnit Get(Projection projection, Int32 ouId)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projection, ouId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnit Get(Projection projection, Int32 ouId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projection, ouId, fetchMode);
		}

		public OrganizationalUnit Get(string projectionName, Int32 ouId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projectionName, ouId, fields);
		}

		public OrganizationalUnit Get(Projection projection, Int32 ouId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnit>)this).Get(projection, ouId, fields);
		}

		public bool Delete(Int32 ouId)
		{
			var entity = new OrganizationalUnit { OuId = ouId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(string projectionName, Int32 ouId)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projectionName, ouId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(string projectionName, Int32 ouId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projectionName, ouId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(Projection projection, Int32 ouId)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projection, ouId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(Projection projection, Int32 ouId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projection, ouId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(string projectionName, Int32 ouId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projectionName, ouId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnit> GetAsync(Projection projection, Int32 ouId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnit>)this).GetAsync(projection, ouId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ouId)
		{
			var entity = new OrganizationalUnit { OuId = ouId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitFields
	{
		public const string OuId = "OuId";
		public const string OuName = "OuName";
		public const string OuDescription = "OuDescription";
		public const string OuCode = "OuCode";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string IsActive = "IsActive";
		public const string OuParentId = "OuParentId";
		public const string OuTypeId = "OuTypeId";
		public const string HasAdvisor = "HasAdvisor";
		public const string CurrencySymbol = "CurrencySymbol";
		public const string RightSymbol = "RightSymbol";
		public const string CurrencyId = "CurrencyId";
		public const string OuCountryCode = "OuCountryCode";
		public const string DepartmentId = "DepartmentId";
		public const string HasOdsSearch = "HasOdsSearch";
		public const string HcoOds = "HcoOds";
		public const string HasLinkZinc = "HasLinkZinc";
		public const string AllowApprovalPrivateOrganization = "AllowApprovalPrivateOrganization";
		public const string ShowThirdPartyLogisticsVendorTab = "ShowThirdPartyLogisticsVendorTab";
		public const string InputCharactersRemaining = "InputCharactersRemaining";
		public const string RecipientEntityTypeId = "RecipientEntityTypeId";
		public const string AllowHcoInProfessionalServices = "AllowHcoInProfessionalServices";
		public const string AllowChangeAdvisorToDecisionMaker = "AllowChangeAdvisorToDecisionMaker";
		public const string AllowSupportGroupSubmitForms = "AllowSupportGroupSubmitForms";
		public const string BlockBudgetReconciliation = "BlockBudgetReconciliation";
		public const string AllowSelectionAdvisorsDecisionMaker = "AllowSelectionAdvisorsDecisionMaker";
		public const string RemoveAdvisorInSendBackInitiator = "RemoveAdvisorInSendBackInitiator";
		public const string CountryWithCertification = "CountryWithCertification";
		public const string RolesSyncWithAd = "RolesSyncWithAd";
		public const string NtGroupName = "NtGroupName";
		public const string OnlyHasApprovalPhase = "OnlyHasApprovalPhase";
		public const string WbsSelectable = "WbsSelectable";
		public const string HasAttendeesExtended = "HasAttendeesExtended";
		public const string HasSolicitedUnsolicited = "HasSolicitedUnsolicited";
		public const string HasProductProjectActivity = "HasProductProjectActivity";
		public const string HasSearchSapProvider = "HasSearchSapProvider";
		public const string InfieldActivity = "InfieldActivity";
		public const string HasInternalOrders = "HasInternalOrders";
		public const string AllGenerateContract = "AllGenerateContract";
		public const string HasRecipientsStatusTracking = "HasRecipientsStatusTracking";
		public const string HasSignedContracts = "HasSignedContracts";
		public const string ActivateEventsModule = "ActivateEventsModule";
		public const string AllowSupportGroupToCancelForms = "AllowSupportGroupToCancelForms";
		public const string SelectLoadModeRecipientsDetails = "SelectLoadModeRecipientsDetails";
		public const string IsOdsLocal = "IsOdsLocal";
		public const string IsEnableDisableAutomaticContractingTool = "IsEnableDisableAutomaticContractingTool";
		public const string AdditionalApprovalBeforeCloseout = "AdditionalApprovalBeforeCloseout";
		public const string IsSapLocal = "IsSapLocal";
		public const string HasLogisticalArrangementsExtended = "HasLogisticalArrangementsExtended";
		public const string AdditionalApprovalBeforeCloseoutRolId = "AdditionalApprovalBeforeCloseoutRolId";
		public const string IsOuAllergan = "IsOuAllergan";
		public const string IsCrossBorderHost = "IsCrossBorderHost";
		public const string IsCrossBorderHome = "IsCrossBorderHome";
		public const string IsCrossBorder = "IsCrossBorder";
		public const string HasMassiveUploadAssistants = "HasMassiveUploadAssistants";
		public const string HasInvitationLettersAssistants = "HasInvitationLettersAssistants";
		public const string HasPsExtendedGeneric = "HasPsExtendedGeneric";
		public const string HasLogisticalReconciliation = "HasLogisticalReconciliation";
		public const string HasFinancialData = "HasFinancialData";
		public const string UseMdm = "UseMdm";
		public const string HasAllerganContractTemplate = "HasAllerganContractTemplate";
		public const string UpLevel = "UpLevel";
		public const string Path = "Path";
		public const string OuCountryId = "OuCountryId";
	}

	public static partial class OrganizationalUnitProjections
	{
		public const string BaseTable = "BaseTable";
		public const string FullHierarchy = "FullHierarchy";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="file_contents")]
	public partial class FileContent
	{
		private Guid _fileContentGuid;
		[DataMember]
		[SqlField(DbType.Guid, 16, IsKey=true, ColumnName ="file_content_guid", BaseColumnName ="file_content_guid", BaseTableName = "file_contents" )]		
		public Guid FileContentGuid 
		{ 
		    get { return _fileContentGuid; } 
			set 
			{
			    _fileContentGuid = value;
			}
        }

		private Int32 _fileSize;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsReadOnly = true, ColumnName ="file_size", BaseColumnName ="file_size", BaseTableName = "file_contents" )]		
		public Int32 FileSize 
		{ 
		    get { return _fileSize; } 
			set 
			{
			    _fileSize = value;
			}
        }

		private Boolean _isCompleted;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_completed", BaseColumnName ="is_completed", BaseTableName = "file_contents" )]		
		public Boolean IsCompleted 
		{ 
		    get { return _isCompleted; } 
			set 
			{
			    _isCompleted = value;
			}
        }

		private String _pathName;
		[DataMember]
		[SqlField(DbType.String, 4000, IsReadOnly = true, ColumnName ="path_name" )]		
		public String PathName 
		{ 
		    get { return _pathName; } 
			set 
			{
			    _pathName = value;
			}
        }

		private Byte[] _transactionContext;
		[DataMember]
		[SqlField(DbType.Binary, 128, IsReadOnly = true, ColumnName ="transaction_context" )]		
		public Byte[] TransactionContext 
		{ 
		    get { return _transactionContext; } 
			set 
			{
			    _transactionContext = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "file_contents" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "file_contents" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[file_content_guid], [file_content], [file_size], [is_completed], [created_by], [created_date]";
		public const string MinimalProjectionColumnList = "[file_content_guid], [file_size], [is_completed], [path_name], [transaction_context], [created_date], [created_by]";

	}

	public partial class FileContentRepository : Repository<FileContent> 
	{
		public FileContentRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public FileContent Get(string projectionName, Guid fileContentGuid)
		{
			return ((IRepository<FileContent>)this).Get(projectionName, fileContentGuid, FetchMode.UseIdentityMap);
		}

		public FileContent Get(string projectionName, Guid fileContentGuid, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FileContent>)this).Get(projectionName, fileContentGuid, fetchMode);
		}

		public FileContent Get(Projection projection, Guid fileContentGuid)
		{
			return ((IRepository<FileContent>)this).Get(projection, fileContentGuid, FetchMode.UseIdentityMap);
		}

		public FileContent Get(Projection projection, Guid fileContentGuid, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FileContent>)this).Get(projection, fileContentGuid, fetchMode);
		}

		public FileContent Get(string projectionName, Guid fileContentGuid, params string[] fields)
		{
			return ((IRepository<FileContent>)this).Get(projectionName, fileContentGuid, fields);
		}

		public FileContent Get(Projection projection, Guid fileContentGuid, params string[] fields)
		{
			return ((IRepository<FileContent>)this).Get(projection, fileContentGuid, fields);
		}

		public bool Delete(Guid fileContentGuid)
		{
			var entity = new FileContent { FileContentGuid = fileContentGuid };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<FileContent> GetAsync(string projectionName, Guid fileContentGuid)
		{
			return ((IRepository<FileContent>)this).GetAsync(projectionName, fileContentGuid, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<FileContent> GetAsync(string projectionName, Guid fileContentGuid, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FileContent>)this).GetAsync(projectionName, fileContentGuid, fetchMode);
		}

		public System.Threading.Tasks.Task<FileContent> GetAsync(Projection projection, Guid fileContentGuid)
		{
			return ((IRepository<FileContent>)this).GetAsync(projection, fileContentGuid, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<FileContent> GetAsync(Projection projection, Guid fileContentGuid, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FileContent>)this).GetAsync(projection, fileContentGuid, fetchMode);
		}

		public System.Threading.Tasks.Task<FileContent> GetAsync(string projectionName, Guid fileContentGuid, params string[] fields)
		{
			return ((IRepository<FileContent>)this).GetAsync(projectionName, fileContentGuid, fields);
		}

		public System.Threading.Tasks.Task<FileContent> GetAsync(Projection projection, Guid fileContentGuid, params string[] fields)
		{
			return ((IRepository<FileContent>)this).GetAsync(projection, fileContentGuid, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Guid fileContentGuid)
		{
			var entity = new FileContent { FileContentGuid = fileContentGuid };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class FileContentFields
	{
		public const string FileContentGuid = "FileContentGuid";
		public const string FileSize = "FileSize";
		public const string IsCompleted = "IsCompleted";
		public const string PathName = "PathName";
		public const string TransactionContext = "TransactionContext";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
	}

	public static partial class FileContentProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Minimal = "Minimal";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_types")]
	public partial class OrganizationalUnitType
	{
		private Int32 _ouTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_type_id", BaseColumnName ="ou_type_id", BaseTableName = "organizational_unit_types" )]		
		public Int32 OuTypeId 
		{ 
		    get { return _ouTypeId; } 
			set 
			{
			    _ouTypeId = value;
			}
        }

		private String _ouTypeInvariantName;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="ou_type_invariant_name", BaseColumnName ="ou_type_invariant_name", BaseTableName = "organizational_unit_types" )]		
		public String OuTypeInvariantName 
		{ 
		    get { return _ouTypeInvariantName; } 
			set 
			{
			    _ouTypeInvariantName = value;
			}
        }

		private String _ouTypeNameLocalizable;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_type_name_localizable", BaseColumnName ="ou_type_name_localizable", BaseTableName = "organizational_unit_types" )]		
		public String OuTypeNameLocalizable 
		{ 
		    get { return _ouTypeNameLocalizable; } 
			set 
			{
			    _ouTypeNameLocalizable = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_type_id], [ou_type_invariant_name], [ou_type_name_localizable]";

	}

	public partial class OrganizationalUnitTypeRepository : Repository<OrganizationalUnitType> 
	{
		public OrganizationalUnitTypeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitType Get(string projectionName, Int32 ouTypeId)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projectionName, ouTypeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitType Get(string projectionName, Int32 ouTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projectionName, ouTypeId, fetchMode);
		}

		public OrganizationalUnitType Get(Projection projection, Int32 ouTypeId)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projection, ouTypeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitType Get(Projection projection, Int32 ouTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projection, ouTypeId, fetchMode);
		}

		public OrganizationalUnitType Get(string projectionName, Int32 ouTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projectionName, ouTypeId, fields);
		}

		public OrganizationalUnitType Get(Projection projection, Int32 ouTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitType>)this).Get(projection, ouTypeId, fields);
		}

		public bool Delete(Int32 ouTypeId)
		{
			var entity = new OrganizationalUnitType { OuTypeId = ouTypeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(string projectionName, Int32 ouTypeId)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projectionName, ouTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(string projectionName, Int32 ouTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projectionName, ouTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(Projection projection, Int32 ouTypeId)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projection, ouTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(Projection projection, Int32 ouTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projection, ouTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(string projectionName, Int32 ouTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projectionName, ouTypeId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitType> GetAsync(Projection projection, Int32 ouTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitType>)this).GetAsync(projection, ouTypeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ouTypeId)
		{
			var entity = new OrganizationalUnitType { OuTypeId = ouTypeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitTypeFields
	{
		public const string OuTypeId = "OuTypeId";
		public const string OuTypeInvariantName = "OuTypeInvariantName";
		public const string OuTypeNameLocalizable = "OuTypeNameLocalizable";
	}

	public static partial class OrganizationalUnitTypeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_products")]
	public partial class OrganizationalUnitProduct
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_products" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32 _itemId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="item_id", BaseColumnName ="item_id", BaseTableName = "organizational_unit_products" )]		
		public Int32 ItemId 
		{ 
		    get { return _itemId; } 
			set 
			{
			    _itemId = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_products" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_products" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private String _itemNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="item_name_localizable" )]		
		public String ItemNameLocalizable 
		{ 
		    get { return _itemNameLocalizable; } 
			set 
			{
			    _itemNameLocalizable = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [item_id], [created_by], [created_date]";
		public const string BasicProjectionColumnList = "[ou_id], [item_id], [ou_name], [item_name_localizable]";

	}

	public partial class OrganizationalUnitProductRepository : Repository<OrganizationalUnitProduct> 
	{
		public OrganizationalUnitProductRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}


		public void AddAllProductsIntoOu(Int32? ouId)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateAddAllProductsIntoOuProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "ou_id"].Value = ouId == null ? (object) DBNull.Value : ouId.Value;
                    return proc;
                }
            };

			executor.ExecuteNonQuery();
		}

		public async System.Threading.Tasks.Task AddAllProductsIntoOuAsync(Int32? ouId)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateAddAllProductsIntoOuProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "ou_id"].Value = ouId == null ? (object) DBNull.Value : ouId.Value;
                    return proc;
                }
            };

			await executor.ExecuteNonQueryAsync().ConfigureAwait(false);
		}
	}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitProductFields
	{
		public const string OuId = "OuId";
		public const string ItemId = "ItemId";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string OuName = "OuName";
		public const string ItemNameLocalizable = "ItemNameLocalizable";
	}

	public static partial class OrganizationalUnitProductProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_teams")]
	public partial class OrganizationalUnitTeam
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_teams" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32 _teamId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="team_id", BaseColumnName ="team_id", BaseTableName = "organizational_unit_teams" )]		
		public Int32 TeamId 
		{ 
		    get { return _teamId; } 
			set 
			{
			    _teamId = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_teams" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_teams" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private String _teamName;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="team_name" )]		
		public String TeamName 
		{ 
		    get { return _teamName; } 
			set 
			{
			    _teamName = value;
			}
        }

		private String _teamCode;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="team_code" )]		
		public String TeamCode 
		{ 
		    get { return _teamCode; } 
			set 
			{
			    _teamCode = value;
			}
        }

		private String _teamNameComplete;
		[DataMember]
		[SqlField(DbType.String, 631, IsReadOnly = true, ColumnName ="team_name_complete" )]		
		public String TeamNameComplete 
		{ 
		    get { return _teamNameComplete; } 
			set 
			{
			    _teamNameComplete = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [team_id], [created_by], [created_date]";
		public const string BasicProjectionColumnList = "[ou_id], [team_id], [ou_name], [team_name], [team_code], [team_name_complete]";

	}

	public partial class OrganizationalUnitTeamRepository : Repository<OrganizationalUnitTeam> 
	{
		public OrganizationalUnitTeamRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitTeamFields
	{
		public const string OuId = "OuId";
		public const string TeamId = "TeamId";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string OuName = "OuName";
		public const string TeamName = "TeamName";
		public const string TeamCode = "TeamCode";
		public const string TeamNameComplete = "TeamNameComplete";
	}

	public static partial class OrganizationalUnitTeamProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_car_products")]
	public partial class OrganizationalUnitCarProduct
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_car_products" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32 _productId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="product_id", BaseColumnName ="product_id", BaseTableName = "organizational_unit_car_products" )]		
		public Int32 ProductId 
		{ 
		    get { return _productId; } 
			set 
			{
			    _productId = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_car_products" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_car_products" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private String _productName;
		[DataMember]
		[SqlField(DbType.String, 256, IsReadOnly = true, ColumnName ="product_name" )]		
		public String ProductName 
		{ 
		    get { return _productName; } 
			set 
			{
			    _productName = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [product_id], [created_by], [created_date]";
		public const string BasicProjectionColumnList = "[ou_id], [product_id], [ou_name], [product_name]";

	}

	public partial class OrganizationalUnitCarProductRepository : Repository<OrganizationalUnitCarProduct> 
	{
		public OrganizationalUnitCarProductRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitCarProductFields
	{
		public const string OuId = "OuId";
		public const string ProductId = "ProductId";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string OuName = "OuName";
		public const string ProductName = "ProductName";
	}

	public static partial class OrganizationalUnitCarProductProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_company_codes")]
	public partial class OrganizationalUnitCompanyCode
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_company_codes" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _companyCode;
		[DataMember]
		[SqlField(DbType.String, 128, IsKey=true, ColumnName ="company_code", BaseColumnName ="company_code", BaseTableName = "organizational_unit_company_codes" )]		
		public String CompanyCode 
		{ 
		    get { return _companyCode; } 
			set 
			{
			    _companyCode = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_company_codes" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_company_codes" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Boolean _isDefault;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_default", BaseColumnName ="is_default", BaseTableName = "organizational_unit_company_codes" )]		
		public Boolean IsDefault 
		{ 
		    get { return _isDefault; } 
			set 
			{
			    _isDefault = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [company_code], [created_by], [created_date], [is_default]";

	}

	public partial class OrganizationalUnitCompanyCodeRepository : Repository<OrganizationalUnitCompanyCode> 
	{
		public OrganizationalUnitCompanyCodeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

	}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitCompanyCodeFields
	{
		public const string OuId = "OuId";
		public const string CompanyCode = "CompanyCode";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string IsDefault = "IsDefault";
	}

	public static partial class OrganizationalUnitCompanyCodeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_contracts")]
	public partial class OrganizationalUnitContract
	{
		private Int32 _ouContractId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "organizational_unit_contracts_ou_contract_id_seq", ColumnName ="ou_contract_id", BaseColumnName ="ou_contract_id", BaseTableName = "organizational_unit_contracts" )]		
		public Int32 OuContractId 
		{ 
		    get { return _ouContractId; } 
			set 
			{
			    _ouContractId = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_contracts" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _fullNameAbbvie;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="full_name_abbvie", BaseColumnName ="full_name_abbvie", BaseTableName = "organizational_unit_contracts" )]		
		public String FullNameAbbvie 
		{ 
		    get { return _fullNameAbbvie; } 
			set 
			{
			    _fullNameAbbvie = value;
			}
        }

		private String _address;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="address", BaseColumnName ="address", BaseTableName = "organizational_unit_contracts" )]		
		public String Address 
		{ 
		    get { return _address; } 
			set 
			{
			    _address = value;
			}
        }

		private String _city;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="city", BaseColumnName ="city", BaseTableName = "organizational_unit_contracts" )]		
		public String City 
		{ 
		    get { return _city; } 
			set 
			{
			    _city = value;
			}
        }

		private Int32 _countryId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="country_id", BaseColumnName ="country_id", BaseTableName = "organizational_unit_contracts" )]		
		public Int32 CountryId 
		{ 
		    get { return _countryId; } 
			set 
			{
			    _countryId = value;
			}
        }

		private String _userName;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="user_name", BaseColumnName ="user_name", BaseTableName = "organizational_unit_contracts" )]		
		public String UserName 
		{ 
		    get { return _userName; } 
			set 
			{
			    _userName = value;
			}
        }

		private String _otherInformation;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="other_information", BaseColumnName ="other_information", BaseTableName = "organizational_unit_contracts" )]		
		public String OtherInformation 
		{ 
		    get { return _otherInformation; } 
			set 
			{
			    _otherInformation = value;
			}
        }

		private String _userFunction;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="user_function", BaseColumnName ="user_function", BaseTableName = "organizational_unit_contracts" )]		
		public String UserFunction 
		{ 
		    get { return _userFunction; } 
			set 
			{
			    _userFunction = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_contracts" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_contracts" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_contracts" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_contracts" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_contract_id], [ou_id], [full_name_abbvie], [address], [city], [country_id], [user_name], [other_information], [user_function], [created_by], [created_date], [modified_by], [modified_date]";

	}

	public partial class OrganizationalUnitContractRepository : Repository<OrganizationalUnitContract> 
	{
		public OrganizationalUnitContractRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitContract Get(string projectionName, Int32 ouContractId)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projectionName, ouContractId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitContract Get(string projectionName, Int32 ouContractId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projectionName, ouContractId, fetchMode);
		}

		public OrganizationalUnitContract Get(Projection projection, Int32 ouContractId)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projection, ouContractId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitContract Get(Projection projection, Int32 ouContractId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projection, ouContractId, fetchMode);
		}

		public OrganizationalUnitContract Get(string projectionName, Int32 ouContractId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projectionName, ouContractId, fields);
		}

		public OrganizationalUnitContract Get(Projection projection, Int32 ouContractId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitContract>)this).Get(projection, ouContractId, fields);
		}

		public bool Delete(Int32 ouContractId)
		{
			var entity = new OrganizationalUnitContract { OuContractId = ouContractId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(string projectionName, Int32 ouContractId)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projectionName, ouContractId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(string projectionName, Int32 ouContractId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projectionName, ouContractId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(Projection projection, Int32 ouContractId)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projection, ouContractId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(Projection projection, Int32 ouContractId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projection, ouContractId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(string projectionName, Int32 ouContractId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projectionName, ouContractId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitContract> GetAsync(Projection projection, Int32 ouContractId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitContract>)this).GetAsync(projection, ouContractId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ouContractId)
		{
			var entity = new OrganizationalUnitContract { OuContractId = ouContractId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitContractFields
	{
		public const string OuContractId = "OuContractId";
		public const string OuId = "OuId";
		public const string FullNameAbbvie = "FullNameAbbvie";
		public const string Address = "Address";
		public const string City = "City";
		public const string CountryId = "CountryId";
		public const string UserName = "UserName";
		public const string OtherInformation = "OtherInformation";
		public const string UserFunction = "UserFunction";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ModifiedDate = "ModifiedDate";
	}

	public static partial class OrganizationalUnitContractProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_hco_sap_providers")]
	public partial class OrganizationalUnitHcoSapProvider
	{
		private Int32 _ouHcoSapProviderId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "organizational_unit_hco_sap_providers_ou_hco_sap_provider_id_seq", ColumnName ="ou_hco_sap_provider_id", BaseColumnName ="ou_hco_sap_provider_id", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32 OuHcoSapProviderId 
		{ 
		    get { return _ouHcoSapProviderId; } 
			set 
			{
			    _ouHcoSapProviderId = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _hcoCode;
		[DataMember]
		[SqlField(DbType.String, 256, ColumnName ="hco_code", BaseColumnName ="hco_code", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoCode 
		{ 
		    get { return _hcoCode; } 
			set 
			{
			    _hcoCode = value;
			}
        }

		private String _hcoName;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="hco_name", BaseColumnName ="hco_name", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoName 
		{ 
		    get { return _hcoName; } 
			set 
			{
			    _hcoName = value;
			}
        }

		private String _sapProviderCode;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="sap_provider_code", BaseColumnName ="sap_provider_code", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderCode 
		{ 
		    get { return _sapProviderCode; } 
			set 
			{
			    _sapProviderCode = value;
			}
        }

		private String _sapProviderCodeId;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="sap_provider_code_id", BaseColumnName ="sap_provider_code_id", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderCodeId 
		{ 
		    get { return _sapProviderCodeId; } 
			set 
			{
			    _sapProviderCodeId = value;
			}
        }

		private String _sapProviderName;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="sap_provider_name", BaseColumnName ="sap_provider_name", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderName 
		{ 
		    get { return _sapProviderName; } 
			set 
			{
			    _sapProviderName = value;
			}
        }

		private String _sapProviderAddress1;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="sap_provider_address1", BaseColumnName ="sap_provider_address1", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderAddress1 
		{ 
		    get { return _sapProviderAddress1; } 
			set 
			{
			    _sapProviderAddress1 = value;
			}
        }

		private String _sapProviderAddress2;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="sap_provider_address2", BaseColumnName ="sap_provider_address2", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderAddress2 
		{ 
		    get { return _sapProviderAddress2; } 
			set 
			{
			    _sapProviderAddress2 = value;
			}
        }

		private String _sapProviderAddress3;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="sap_provider_address3", BaseColumnName ="sap_provider_address3", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderAddress3 
		{ 
		    get { return _sapProviderAddress3; } 
			set 
			{
			    _sapProviderAddress3 = value;
			}
        }

		private String _sapProviderAddress4;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="sap_provider_address4", BaseColumnName ="sap_provider_address4", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderAddress4 
		{ 
		    get { return _sapProviderAddress4; } 
			set 
			{
			    _sapProviderAddress4 = value;
			}
        }

		private String _sapProviderCity;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="sap_provider_city", BaseColumnName ="sap_provider_city", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderCity 
		{ 
		    get { return _sapProviderCity; } 
			set 
			{
			    _sapProviderCity = value;
			}
        }

		private String _sapProviderCounty;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="sap_provider_county", BaseColumnName ="sap_provider_county", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderCounty 
		{ 
		    get { return _sapProviderCounty; } 
			set 
			{
			    _sapProviderCounty = value;
			}
        }

		private String _sapProviderPostcode;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="sap_provider_postcode", BaseColumnName ="sap_provider_postcode", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String SapProviderPostcode 
		{ 
		    get { return _sapProviderPostcode; } 
			set 
			{
			    _sapProviderPostcode = value;
			}
        }

		private Boolean _hasDonations;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_donations", BaseColumnName ="has_donations", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Boolean HasDonations 
		{ 
		    get { return _hasDonations; } 
			set 
			{
			    _hasDonations = value;
			}
        }

		private Boolean _inObservation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="in_observation", BaseColumnName ="in_observation", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Boolean InObservation 
		{ 
		    get { return _inObservation; } 
			set 
			{
			    _inObservation = value;
			}
        }

		private Boolean _hasPatientsAssociation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="has_patients_association", BaseColumnName ="has_patients_association", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Boolean HasPatientsAssociation 
		{ 
		    get { return _hasPatientsAssociation; } 
			set 
			{
			    _hasPatientsAssociation = value;
			}
        }

		private Int32 _typologyFmvId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="typology_fmv_id", BaseColumnName ="typology_fmv_id", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32 TypologyFmvId 
		{ 
		    get { return _typologyFmvId; } 
			set 
			{
			    _typologyFmvId = value;
			}
        }

		private Guid? _statutesFileContentGuid;
		[DataMember]
		[SqlField(DbType.Guid, 16, AllowNull = true, ColumnName ="statutes_file_content_guid", BaseColumnName ="statutes_file_content_guid", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Guid? StatutesFileContentGuid 
		{ 
		    get { return _statutesFileContentGuid; } 
			set 
			{
			    _statutesFileContentGuid = value;
			}
        }

		private String _statutesFileName;
		[DataMember]
		[SqlField(DbType.String, 240, ColumnName ="statutes_file_name", BaseColumnName ="statutes_file_name", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String StatutesFileName 
		{ 
		    get { return _statutesFileName; } 
			set 
			{
			    _statutesFileName = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Boolean IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32? _sapProviderId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="sap_provider_id", BaseColumnName ="sap_provider_id", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public Int32? SapProviderId 
		{ 
		    get { return _sapProviderId; } 
			set 
			{
			    _sapProviderId = value;
			}
        }

		private String _hcoAddress;
		[DataMember]
		[SqlField(DbType.String, 200, ColumnName ="hco_address", BaseColumnName ="hco_address", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoAddress 
		{ 
		    get { return _hcoAddress; } 
			set 
			{
			    _hcoAddress = value;
			}
        }

		private String _hcoPostcode;
		[DataMember]
		[SqlField(DbType.String, 200, ColumnName ="hco_postcode", BaseColumnName ="hco_postcode", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoPostcode 
		{ 
		    get { return _hcoPostcode; } 
			set 
			{
			    _hcoPostcode = value;
			}
        }

		private String _hcoCity;
		[DataMember]
		[SqlField(DbType.String, 200, ColumnName ="hco_city", BaseColumnName ="hco_city", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoCity 
		{ 
		    get { return _hcoCity; } 
			set 
			{
			    _hcoCity = value;
			}
        }

		private String _hcoCif;
		[DataMember]
		[SqlField(DbType.String, 50, ColumnName ="hco_cif", BaseColumnName ="hco_cif", BaseTableName = "organizational_unit_hco_sap_providers" )]		
		public String HcoCif 
		{ 
		    get { return _hcoCif; } 
			set 
			{
			    _hcoCif = value;
			}
        }

		private Int32? _fileSize;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, IsReadOnly = true, ColumnName ="file_size" )]		
		public Int32? FileSize 
		{ 
		    get { return _fileSize; } 
			set 
			{
			    _fileSize = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_hco_sap_provider_id], [ou_id], [hco_code], [hco_name], [sap_provider_code], [sap_provider_code_id], [sap_provider_name], [sap_provider_address1], [sap_provider_address2], [sap_provider_address3], [sap_provider_address4], [sap_provider_city], [sap_provider_county], [sap_provider_postcode], [has_donations], [in_observation], [has_patients_association], [typology_fmv_id], [statutes_file_content_guid], [statutes_file_name], [is_active], [created_by], [created_date], [modified_by], [modified_date], [sap_provider_id], [hco_address], [hco_postcode], [hco_city], [hco_cif]";
		public const string BasicProjectionColumnList = "[ou_hco_sap_provider_id], [ou_id], [hco_code], [hco_name], [hco_address], [hco_postcode], [hco_city], [hco_cif], [sap_provider_id], [sap_provider_code], [sap_provider_code_id], [sap_provider_name], [sap_provider_address1], [sap_provider_address2], [sap_provider_address3], [sap_provider_address4], [sap_provider_city], [sap_provider_county], [sap_provider_postcode], [has_donations], [in_observation], [has_patients_association], [typology_fmv_id], [statutes_file_content_guid], [statutes_file_name], [file_size], [is_active], [created_by], [created_date], [modified_by], [modified_date]";

	}

	public partial class OrganizationalUnitHcoSapProviderRepository : Repository<OrganizationalUnitHcoSapProvider> 
	{
		public OrganizationalUnitHcoSapProviderRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitHcoSapProvider Get(string projectionName, Int32 ouHcoSapProviderId)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projectionName, ouHcoSapProviderId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitHcoSapProvider Get(string projectionName, Int32 ouHcoSapProviderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projectionName, ouHcoSapProviderId, fetchMode);
		}

		public OrganizationalUnitHcoSapProvider Get(Projection projection, Int32 ouHcoSapProviderId)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projection, ouHcoSapProviderId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitHcoSapProvider Get(Projection projection, Int32 ouHcoSapProviderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projection, ouHcoSapProviderId, fetchMode);
		}

		public OrganizationalUnitHcoSapProvider Get(string projectionName, Int32 ouHcoSapProviderId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projectionName, ouHcoSapProviderId, fields);
		}

		public OrganizationalUnitHcoSapProvider Get(Projection projection, Int32 ouHcoSapProviderId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).Get(projection, ouHcoSapProviderId, fields);
		}

		public bool Delete(Int32 ouHcoSapProviderId)
		{
			var entity = new OrganizationalUnitHcoSapProvider { OuHcoSapProviderId = ouHcoSapProviderId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(string projectionName, Int32 ouHcoSapProviderId)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projectionName, ouHcoSapProviderId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(string projectionName, Int32 ouHcoSapProviderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projectionName, ouHcoSapProviderId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(Projection projection, Int32 ouHcoSapProviderId)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projection, ouHcoSapProviderId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(Projection projection, Int32 ouHcoSapProviderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projection, ouHcoSapProviderId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(string projectionName, Int32 ouHcoSapProviderId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projectionName, ouHcoSapProviderId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitHcoSapProvider> GetAsync(Projection projection, Int32 ouHcoSapProviderId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitHcoSapProvider>)this).GetAsync(projection, ouHcoSapProviderId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ouHcoSapProviderId)
		{
			var entity = new OrganizationalUnitHcoSapProvider { OuHcoSapProviderId = ouHcoSapProviderId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitHcoSapProviderFields
	{
		public const string OuHcoSapProviderId = "OuHcoSapProviderId";
		public const string OuId = "OuId";
		public const string HcoCode = "HcoCode";
		public const string HcoName = "HcoName";
		public const string SapProviderCode = "SapProviderCode";
		public const string SapProviderCodeId = "SapProviderCodeId";
		public const string SapProviderName = "SapProviderName";
		public const string SapProviderAddress1 = "SapProviderAddress1";
		public const string SapProviderAddress2 = "SapProviderAddress2";
		public const string SapProviderAddress3 = "SapProviderAddress3";
		public const string SapProviderAddress4 = "SapProviderAddress4";
		public const string SapProviderCity = "SapProviderCity";
		public const string SapProviderCounty = "SapProviderCounty";
		public const string SapProviderPostcode = "SapProviderPostcode";
		public const string HasDonations = "HasDonations";
		public const string InObservation = "InObservation";
		public const string HasPatientsAssociation = "HasPatientsAssociation";
		public const string TypologyFmvId = "TypologyFmvId";
		public const string StatutesFileContentGuid = "StatutesFileContentGuid";
		public const string StatutesFileName = "StatutesFileName";
		public const string IsActive = "IsActive";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string SapProviderId = "SapProviderId";
		public const string HcoAddress = "HcoAddress";
		public const string HcoPostcode = "HcoPostcode";
		public const string HcoCity = "HcoCity";
		public const string HcoCif = "HcoCif";
		public const string FileSize = "FileSize";
	}

	public static partial class OrganizationalUnitHcoSapProviderProjections
	{
		public const string BaseTable = "BaseTable";
		public const string Basic = "Basic";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_signers")]
	public partial class OrganizationalUnitSigner
	{
		private Int32 _signerId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "organizational_unit_signers_signer_id_seq", ColumnName ="signer_id", BaseColumnName ="signer_id", BaseTableName = "organizational_unit_signers" )]		
		public Int32 SignerId 
		{ 
		    get { return _signerId; } 
			set 
			{
			    _signerId = value;
			}
        }

		private String _signerName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="signer_name", BaseColumnName ="signer_name", BaseTableName = "organizational_unit_signers" )]		
		public String SignerName 
		{ 
		    get { return _signerName; } 
			set 
			{
			    _signerName = value;
			}
        }

		private String _signerTitle;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="signer_title", BaseColumnName ="signer_title", BaseTableName = "organizational_unit_signers" )]		
		public String SignerTitle 
		{ 
		    get { return _signerTitle; } 
			set 
			{
			    _signerTitle = value;
			}
        }

		private String _signerDni;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="signer_dni", BaseColumnName ="signer_dni", BaseTableName = "organizational_unit_signers" )]		
		public String SignerDni 
		{ 
		    get { return _signerDni; } 
			set 
			{
			    _signerDni = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_signers" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Boolean _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "organizational_unit_signers" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_signers" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_signers" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_signers" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_signers" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private String _signerEmail;
		[DataMember]
		[SqlField(DbType.String, 200, ColumnName ="signer_email", BaseColumnName ="signer_email", BaseTableName = "organizational_unit_signers" )]		
		public String SignerEmail 
		{ 
		    get { return _signerEmail; } 
			set 
			{
			    _signerEmail = value;
			}
        }

		private Boolean _isLegalRepresentative;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="is_legal_representative", BaseColumnName ="is_legal_representative", BaseTableName = "organizational_unit_signers" )]		
		public Boolean IsLegalRepresentative 
		{ 
		    get { return _isLegalRepresentative; } 
			set 
			{
			    _isLegalRepresentative = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[signer_id], [signer_name], [signer_title], [signer_dni], [ou_id], [is_active], [created_date], [created_by], [modified_date], [modified_by], [signer_email], [is_legal_representative]";

	}

	public partial class OrganizationalUnitSignerRepository : Repository<OrganizationalUnitSigner> 
	{
		public OrganizationalUnitSignerRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitSigner Get(string projectionName, Int32 signerId)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projectionName, signerId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitSigner Get(string projectionName, Int32 signerId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projectionName, signerId, fetchMode);
		}

		public OrganizationalUnitSigner Get(Projection projection, Int32 signerId)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projection, signerId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitSigner Get(Projection projection, Int32 signerId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projection, signerId, fetchMode);
		}

		public OrganizationalUnitSigner Get(string projectionName, Int32 signerId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projectionName, signerId, fields);
		}

		public OrganizationalUnitSigner Get(Projection projection, Int32 signerId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).Get(projection, signerId, fields);
		}

		public bool Delete(Int32 signerId)
		{
			var entity = new OrganizationalUnitSigner { SignerId = signerId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(string projectionName, Int32 signerId)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projectionName, signerId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(string projectionName, Int32 signerId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projectionName, signerId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(Projection projection, Int32 signerId)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projection, signerId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(Projection projection, Int32 signerId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projection, signerId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(string projectionName, Int32 signerId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projectionName, signerId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitSigner> GetAsync(Projection projection, Int32 signerId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitSigner>)this).GetAsync(projection, signerId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 signerId)
		{
			var entity = new OrganizationalUnitSigner { SignerId = signerId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitSignerFields
	{
		public const string SignerId = "SignerId";
		public const string SignerName = "SignerName";
		public const string SignerTitle = "SignerTitle";
		public const string SignerDni = "SignerDni";
		public const string OuId = "OuId";
		public const string IsActive = "IsActive";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string SignerEmail = "SignerEmail";
		public const string IsLegalRepresentative = "IsLegalRepresentative";
	}

	public static partial class OrganizationalUnitSignerProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_abbvie_entities")]
	public partial class OrganizationalUnitAbbvieEntity
	{
		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_abbvie_entities" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private Int32 _abbvieEntityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="abbvie_entity_id", BaseColumnName ="abbvie_entity_id", BaseTableName = "organizational_unit_abbvie_entities" )]		
		public Int32 AbbvieEntityId 
		{ 
		    get { return _abbvieEntityId; } 
			set 
			{
			    _abbvieEntityId = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_abbvie_entities" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_abbvie_entities" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_id], [abbvie_entity_id], [created_by], [created_date]";

	}

	public partial class OrganizationalUnitAbbvieEntityRepository : Repository<OrganizationalUnitAbbvieEntity> 
	{
		public OrganizationalUnitAbbvieEntityRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}


		public void UpdateAbbvieEntitiesOus(String ouId, String abbvieEntityIds, String createdBy)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateUpdateAbbvieEntitiesOusProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "ou_id"].Value = ouId == null ? (object) DBNull.Value : ouId;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "abbvie_entity_ids"].Value = abbvieEntityIds == null ? (object) DBNull.Value : abbvieEntityIds;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "createdBy"].Value = createdBy == null ? (object) DBNull.Value : createdBy;
                    return proc;
                }
            };

			executor.ExecuteNonQuery();
		}

		public async System.Threading.Tasks.Task UpdateAbbvieEntitiesOusAsync(String ouId, String abbvieEntityIds, String createdBy)
		{
            var executor = new StoredProcedureExecutor(this.DataService, true)
            {
                GetCommandFunc = () =>
                {
                    var proc =  WebApi.Entities.StoredProcedures.CreateUpdateAbbvieEntitiesOusProcedure(this.DataService.Connection, this.DataService.EntityLiteProvider.ParameterPrefix, this.DataService.EntityLiteProvider.DefaultSchema);
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "ou_id"].Value = ouId == null ? (object) DBNull.Value : ouId;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "abbvie_entity_ids"].Value = abbvieEntityIds == null ? (object) DBNull.Value : abbvieEntityIds;
					proc.Parameters[this.DataService.EntityLiteProvider.ParameterPrefix + "createdBy"].Value = createdBy == null ? (object) DBNull.Value : createdBy;
                    return proc;
                }
            };

			await executor.ExecuteNonQueryAsync().ConfigureAwait(false);
		}
	}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitAbbvieEntityFields
	{
		public const string OuId = "OuId";
		public const string AbbvieEntityId = "AbbvieEntityId";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
	}

	public static partial class OrganizationalUnitAbbvieEntityProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_event_tax_ranges")]
	[ParentPropertyName("OuId")]
	public partial class OrganizationalUnitEventTaxRange
	{
		private Int32 _taxRangeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="tax_range_id", BaseColumnName ="tax_range_id", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Int32 TaxRangeId 
		{ 
		    get { return _taxRangeId; } 
			set 
			{
			    _taxRangeId = value;
			}
        }

		private Decimal _taxRangeFrom;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, ColumnName ="tax_range_from", BaseColumnName ="tax_range_from", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Decimal TaxRangeFrom 
		{ 
		    get { return _taxRangeFrom; } 
			set 
			{
			    _taxRangeFrom = value;
			}
        }

		private Decimal _taxRangeTo;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, ColumnName ="tax_range_to", BaseColumnName ="tax_range_to", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Decimal TaxRangeTo 
		{ 
		    get { return _taxRangeTo; } 
			set 
			{
			    _taxRangeTo = value;
			}
        }

		private Decimal _taxRangeTax;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, ColumnName ="tax_range_tax", BaseColumnName ="tax_range_tax", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Decimal TaxRangeTax 
		{ 
		    get { return _taxRangeTax; } 
			set 
			{
			    _taxRangeTax = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_event_tax_ranges" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_event_tax_ranges" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_event_tax_ranges" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_event_tax_ranges" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[tax_range_id], [tax_range_from], [tax_range_to], [tax_range_tax], [ou_id], [created_date], [created_by], [modified_date], [modified_by]";

	}

	public partial class OrganizationalUnitEventTaxRangeRepository : Repository<OrganizationalUnitEventTaxRange> 
	{
		public OrganizationalUnitEventTaxRangeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitEventTaxRange Get(string projectionName, Int32 taxRangeId)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projectionName, taxRangeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitEventTaxRange Get(string projectionName, Int32 taxRangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projectionName, taxRangeId, fetchMode);
		}

		public OrganizationalUnitEventTaxRange Get(Projection projection, Int32 taxRangeId)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projection, taxRangeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitEventTaxRange Get(Projection projection, Int32 taxRangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projection, taxRangeId, fetchMode);
		}

		public OrganizationalUnitEventTaxRange Get(string projectionName, Int32 taxRangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projectionName, taxRangeId, fields);
		}

		public OrganizationalUnitEventTaxRange Get(Projection projection, Int32 taxRangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).Get(projection, taxRangeId, fields);
		}

		public bool Delete(Int32 taxRangeId)
		{
			var entity = new OrganizationalUnitEventTaxRange { TaxRangeId = taxRangeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(string projectionName, Int32 taxRangeId)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projectionName, taxRangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(string projectionName, Int32 taxRangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projectionName, taxRangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(Projection projection, Int32 taxRangeId)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projection, taxRangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(Projection projection, Int32 taxRangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projection, taxRangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(string projectionName, Int32 taxRangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projectionName, taxRangeId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitEventTaxRange> GetAsync(Projection projection, Int32 taxRangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitEventTaxRange>)this).GetAsync(projection, taxRangeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 taxRangeId)
		{
			var entity = new OrganizationalUnitEventTaxRange { TaxRangeId = taxRangeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitEventTaxRangeFields
	{
		public const string TaxRangeId = "TaxRangeId";
		public const string TaxRangeFrom = "TaxRangeFrom";
		public const string TaxRangeTo = "TaxRangeTo";
		public const string TaxRangeTax = "TaxRangeTax";
		public const string OuId = "OuId";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
	}

	public static partial class OrganizationalUnitEventTaxRangeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_territory_types")]
	public partial class OrganizationalUnitTerritoryType
	{
		private Int32 _territoryTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="territory_type_id", BaseColumnName ="territory_type_id", BaseTableName = "organizational_unit_territory_types" )]		
		public Int32 TerritoryTypeId 
		{ 
		    get { return _territoryTypeId; } 
			set 
			{
			    _territoryTypeId = value;
			}
        }

		private String _territoryTypeNameLocalizable;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="territory_type_name_localizable", BaseColumnName ="territory_type_name_localizable", BaseTableName = "organizational_unit_territory_types" )]		
		public String TerritoryTypeNameLocalizable 
		{ 
		    get { return _territoryTypeNameLocalizable; } 
			set 
			{
			    _territoryTypeNameLocalizable = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[territory_type_id], [territory_type_name_localizable]";

	}

	public partial class OrganizationalUnitTerritoryTypeRepository : Repository<OrganizationalUnitTerritoryType> 
	{
		public OrganizationalUnitTerritoryTypeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitTerritoryType Get(string projectionName, Int32 territoryTypeId)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projectionName, territoryTypeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitTerritoryType Get(string projectionName, Int32 territoryTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projectionName, territoryTypeId, fetchMode);
		}

		public OrganizationalUnitTerritoryType Get(Projection projection, Int32 territoryTypeId)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projection, territoryTypeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitTerritoryType Get(Projection projection, Int32 territoryTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projection, territoryTypeId, fetchMode);
		}

		public OrganizationalUnitTerritoryType Get(string projectionName, Int32 territoryTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projectionName, territoryTypeId, fields);
		}

		public OrganizationalUnitTerritoryType Get(Projection projection, Int32 territoryTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).Get(projection, territoryTypeId, fields);
		}

		public bool Delete(Int32 territoryTypeId)
		{
			var entity = new OrganizationalUnitTerritoryType { TerritoryTypeId = territoryTypeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(string projectionName, Int32 territoryTypeId)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projectionName, territoryTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(string projectionName, Int32 territoryTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projectionName, territoryTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(Projection projection, Int32 territoryTypeId)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projection, territoryTypeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(Projection projection, Int32 territoryTypeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projection, territoryTypeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(string projectionName, Int32 territoryTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projectionName, territoryTypeId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritoryType> GetAsync(Projection projection, Int32 territoryTypeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritoryType>)this).GetAsync(projection, territoryTypeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 territoryTypeId)
		{
			var entity = new OrganizationalUnitTerritoryType { TerritoryTypeId = territoryTypeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitTerritoryTypeFields
	{
		public const string TerritoryTypeId = "TerritoryTypeId";
		public const string TerritoryTypeNameLocalizable = "TerritoryTypeNameLocalizable";
	}

	public static partial class OrganizationalUnitTerritoryTypeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_territories")]
	public partial class OrganizationalUnitTerritory
	{
		private Int32 _territoryId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="territory_id", BaseColumnName ="territory_id", BaseTableName = "organizational_unit_territories" )]		
		public Int32 TerritoryId 
		{ 
		    get { return _territoryId; } 
			set 
			{
			    _territoryId = value;
			}
        }

		private Int32 _ouCountryId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_country_id", BaseColumnName ="ou_country_id", BaseTableName = "organizational_unit_territories" )]		
		public Int32 OuCountryId 
		{ 
		    get { return _ouCountryId; } 
			set 
			{
			    _ouCountryId = value;
			}
        }

		private Int32? _territoryParentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="territory_parent_id", BaseColumnName ="territory_parent_id", BaseTableName = "organizational_unit_territories" )]		
		public Int32? TerritoryParentId 
		{ 
		    get { return _territoryParentId; } 
			set 
			{
			    _territoryParentId = value;
			}
        }

		private Int32 _territoryTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="territory_type_id", BaseColumnName ="territory_type_id", BaseTableName = "organizational_unit_territories" )]		
		public Int32 TerritoryTypeId 
		{ 
		    get { return _territoryTypeId; } 
			set 
			{
			    _territoryTypeId = value;
			}
        }

		private String _territoyName;
		[DataMember]
		[SqlField(DbType.String, 256, ColumnName ="territoy_name", BaseColumnName ="territoy_name", BaseTableName = "organizational_unit_territories" )]		
		public String TerritoyName 
		{ 
		    get { return _territoyName; } 
			set 
			{
			    _territoyName = value;
			}
        }

		private String _territoryCode;
		[DataMember]
		[SqlField(DbType.String, 256, ColumnName ="territory_code", BaseColumnName ="territory_code", BaseTableName = "organizational_unit_territories" )]		
		public String TerritoryCode 
		{ 
		    get { return _territoryCode; } 
			set 
			{
			    _territoryCode = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_territories" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_territories" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_territories" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_territories" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[territory_id], [ou_country_id], [territory_parent_id], [territory_type_id], [territoy_name], [territory_code], [created_by], [created_date], [modified_by], [modified_date]";

	}

	public partial class OrganizationalUnitTerritoryRepository : Repository<OrganizationalUnitTerritory> 
	{
		public OrganizationalUnitTerritoryRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitTerritory Get(string projectionName, Int32 territoryId)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projectionName, territoryId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitTerritory Get(string projectionName, Int32 territoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projectionName, territoryId, fetchMode);
		}

		public OrganizationalUnitTerritory Get(Projection projection, Int32 territoryId)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projection, territoryId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitTerritory Get(Projection projection, Int32 territoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projection, territoryId, fetchMode);
		}

		public OrganizationalUnitTerritory Get(string projectionName, Int32 territoryId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projectionName, territoryId, fields);
		}

		public OrganizationalUnitTerritory Get(Projection projection, Int32 territoryId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).Get(projection, territoryId, fields);
		}

		public bool Delete(Int32 territoryId)
		{
			var entity = new OrganizationalUnitTerritory { TerritoryId = territoryId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(string projectionName, Int32 territoryId)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projectionName, territoryId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(string projectionName, Int32 territoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projectionName, territoryId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(Projection projection, Int32 territoryId)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projection, territoryId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(Projection projection, Int32 territoryId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projection, territoryId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(string projectionName, Int32 territoryId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projectionName, territoryId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitTerritory> GetAsync(Projection projection, Int32 territoryId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitTerritory>)this).GetAsync(projection, territoryId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 territoryId)
		{
			var entity = new OrganizationalUnitTerritory { TerritoryId = territoryId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitTerritoryFields
	{
		public const string TerritoryId = "TerritoryId";
		public const string OuCountryId = "OuCountryId";
		public const string TerritoryParentId = "TerritoryParentId";
		public const string TerritoryTypeId = "TerritoryTypeId";
		public const string TerritoyName = "TerritoyName";
		public const string TerritoryCode = "TerritoryCode";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ModifiedDate = "ModifiedDate";
	}

	public static partial class OrganizationalUnitTerritoryProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_income_taxes")]
	public partial class OrganizationalUnitIncomeTax
	{
		private Int32 _incomeTaxId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="income_tax_id", BaseColumnName ="income_tax_id", BaseTableName = "organizational_unit_income_taxes" )]		
		public Int32 IncomeTaxId 
		{ 
		    get { return _incomeTaxId; } 
			set 
			{
			    _incomeTaxId = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_income_taxes" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _incomeTaxClass;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="income_tax_class", BaseColumnName ="income_tax_class", BaseTableName = "organizational_unit_income_taxes" )]		
		public String IncomeTaxClass 
		{ 
		    get { return _incomeTaxClass; } 
			set 
			{
			    _incomeTaxClass = value;
			}
        }

		private String _incomeTaxDescription;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="income_tax_description", BaseColumnName ="income_tax_description", BaseTableName = "organizational_unit_income_taxes" )]		
		public String IncomeTaxDescription 
		{ 
		    get { return _incomeTaxDescription; } 
			set 
			{
			    _incomeTaxDescription = value;
			}
        }

		private Boolean _incomeTaxRetention;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="income_tax_retention", BaseColumnName ="income_tax_retention", BaseTableName = "organizational_unit_income_taxes" )]		
		public Boolean IncomeTaxRetention 
		{ 
		    get { return _incomeTaxRetention; } 
			set 
			{
			    _incomeTaxRetention = value;
			}
        }

		private String _incomeTaxCode;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="income_tax_code", BaseColumnName ="income_tax_code", BaseTableName = "organizational_unit_income_taxes" )]		
		public String IncomeTaxCode 
		{ 
		    get { return _incomeTaxCode; } 
			set 
			{
			    _incomeTaxCode = value;
			}
        }

		private String _incomeTaxDocDescription;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="income_tax_doc_description", BaseColumnName ="income_tax_doc_description", BaseTableName = "organizational_unit_income_taxes" )]		
		public String IncomeTaxDocDescription 
		{ 
		    get { return _incomeTaxDocDescription; } 
			set 
			{
			    _incomeTaxDocDescription = value;
			}
        }

		private Boolean? _incomeTaxCreateRegisters;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="income_tax_create_registers", BaseColumnName ="income_tax_create_registers", BaseTableName = "organizational_unit_income_taxes" )]		
		public Boolean? IncomeTaxCreateRegisters 
		{ 
		    get { return _incomeTaxCreateRegisters; } 
			set 
			{
			    _incomeTaxCreateRegisters = value;
			}
        }

		private Boolean? _incomeTaxVatIncludeVendors;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="income_tax_vat_include_vendors", BaseColumnName ="income_tax_vat_include_vendors", BaseTableName = "organizational_unit_income_taxes" )]		
		public Boolean? IncomeTaxVatIncludeVendors 
		{ 
		    get { return _incomeTaxVatIncludeVendors; } 
			set 
			{
			    _incomeTaxVatIncludeVendors = value;
			}
        }

		private Boolean _incomeTaxActivityCode;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="income_tax_activity_code", BaseColumnName ="income_tax_activity_code", BaseTableName = "organizational_unit_income_taxes" )]		
		public Boolean IncomeTaxActivityCode 
		{ 
		    get { return _incomeTaxActivityCode; } 
			set 
			{
			    _incomeTaxActivityCode = value;
			}
        }

		private Decimal _incomeTaxIncomeValue;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, ColumnName ="income_tax_income_value", BaseColumnName ="income_tax_income_value", BaseTableName = "organizational_unit_income_taxes" )]		
		public Decimal IncomeTaxIncomeValue 
		{ 
		    get { return _incomeTaxIncomeValue; } 
			set 
			{
			    _incomeTaxIncomeValue = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_income_taxes" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_income_taxes" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_income_taxes" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_income_taxes" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[income_tax_id], [ou_id], [income_tax_class], [income_tax_description], [income_tax_retention], [income_tax_code], [income_tax_doc_description], [income_tax_create_registers], [income_tax_vat_include_vendors], [income_tax_activity_code], [income_tax_income_value], [created_date], [created_by], [modified_date], [modified_by]";

	}

	public partial class OrganizationalUnitIncomeTaxRepository : Repository<OrganizationalUnitIncomeTax> 
	{
		public OrganizationalUnitIncomeTaxRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitIncomeTax Get(string projectionName, Int32 incomeTaxId)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projectionName, incomeTaxId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitIncomeTax Get(string projectionName, Int32 incomeTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projectionName, incomeTaxId, fetchMode);
		}

		public OrganizationalUnitIncomeTax Get(Projection projection, Int32 incomeTaxId)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projection, incomeTaxId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitIncomeTax Get(Projection projection, Int32 incomeTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projection, incomeTaxId, fetchMode);
		}

		public OrganizationalUnitIncomeTax Get(string projectionName, Int32 incomeTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projectionName, incomeTaxId, fields);
		}

		public OrganizationalUnitIncomeTax Get(Projection projection, Int32 incomeTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).Get(projection, incomeTaxId, fields);
		}

		public bool Delete(Int32 incomeTaxId)
		{
			var entity = new OrganizationalUnitIncomeTax { IncomeTaxId = incomeTaxId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(string projectionName, Int32 incomeTaxId)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projectionName, incomeTaxId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(string projectionName, Int32 incomeTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projectionName, incomeTaxId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(Projection projection, Int32 incomeTaxId)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projection, incomeTaxId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(Projection projection, Int32 incomeTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projection, incomeTaxId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(string projectionName, Int32 incomeTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projectionName, incomeTaxId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIncomeTax> GetAsync(Projection projection, Int32 incomeTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIncomeTax>)this).GetAsync(projection, incomeTaxId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 incomeTaxId)
		{
			var entity = new OrganizationalUnitIncomeTax { IncomeTaxId = incomeTaxId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitIncomeTaxFields
	{
		public const string IncomeTaxId = "IncomeTaxId";
		public const string OuId = "OuId";
		public const string IncomeTaxClass = "IncomeTaxClass";
		public const string IncomeTaxDescription = "IncomeTaxDescription";
		public const string IncomeTaxRetention = "IncomeTaxRetention";
		public const string IncomeTaxCode = "IncomeTaxCode";
		public const string IncomeTaxDocDescription = "IncomeTaxDocDescription";
		public const string IncomeTaxCreateRegisters = "IncomeTaxCreateRegisters";
		public const string IncomeTaxVatIncludeVendors = "IncomeTaxVatIncludeVendors";
		public const string IncomeTaxActivityCode = "IncomeTaxActivityCode";
		public const string IncomeTaxIncomeValue = "IncomeTaxIncomeValue";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
	}

	public static partial class OrganizationalUnitIncomeTaxProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_iva_taxes")]
	public partial class OrganizationalUnitIvaTax
	{
		private Int32 _ivaTaxId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="iva_tax_id", BaseColumnName ="iva_tax_id", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Int32 IvaTaxId 
		{ 
		    get { return _ivaTaxId; } 
			set 
			{
			    _ivaTaxId = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _ivaTaxType;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="iva_tax_type", BaseColumnName ="iva_tax_type", BaseTableName = "organizational_unit_iva_taxes" )]		
		public String IvaTaxType 
		{ 
		    get { return _ivaTaxType; } 
			set 
			{
			    _ivaTaxType = value;
			}
        }

		private Boolean _ivaTaxApplicationType;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="iva_tax_application_type", BaseColumnName ="iva_tax_application_type", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Boolean IvaTaxApplicationType 
		{ 
		    get { return _ivaTaxApplicationType; } 
			set 
			{
			    _ivaTaxApplicationType = value;
			}
        }

		private String _ivaTaxDescription;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="iva_tax_description", BaseColumnName ="iva_tax_description", BaseTableName = "organizational_unit_iva_taxes" )]		
		public String IvaTaxDescription 
		{ 
		    get { return _ivaTaxDescription; } 
			set 
			{
			    _ivaTaxDescription = value;
			}
        }

		private String _ivaTaxClass;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="iva_tax_class", BaseColumnName ="iva_tax_class", BaseTableName = "organizational_unit_iva_taxes" )]		
		public String IvaTaxClass 
		{ 
		    get { return _ivaTaxClass; } 
			set 
			{
			    _ivaTaxClass = value;
			}
        }

		private Boolean _ivaTaxDeductible;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="iva_tax_deductible", BaseColumnName ="iva_tax_deductible", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Boolean IvaTaxDeductible 
		{ 
		    get { return _ivaTaxDeductible; } 
			set 
			{
			    _ivaTaxDeductible = value;
			}
        }

		private Boolean _ivaTaxForeigner;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="iva_tax_foreigner", BaseColumnName ="iva_tax_foreigner", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Boolean IvaTaxForeigner 
		{ 
		    get { return _ivaTaxForeigner; } 
			set 
			{
			    _ivaTaxForeigner = value;
			}
        }

		private Boolean _ivaTaxDeductibleForeigner;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="iva_tax_deductible_foreigner", BaseColumnName ="iva_tax_deductible_foreigner", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Boolean IvaTaxDeductibleForeigner 
		{ 
		    get { return _ivaTaxDeductibleForeigner; } 
			set 
			{
			    _ivaTaxDeductibleForeigner = value;
			}
        }

		private String _ivaTaxLedgerAccount;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="iva_tax_ledger_account", BaseColumnName ="iva_tax_ledger_account", BaseTableName = "organizational_unit_iva_taxes" )]		
		public String IvaTaxLedgerAccount 
		{ 
		    get { return _ivaTaxLedgerAccount; } 
			set 
			{
			    _ivaTaxLedgerAccount = value;
			}
        }

		private String _ivaTaxDistribution;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="iva_tax_distribution", BaseColumnName ="iva_tax_distribution", BaseTableName = "organizational_unit_iva_taxes" )]		
		public String IvaTaxDistribution 
		{ 
		    get { return _ivaTaxDistribution; } 
			set 
			{
			    _ivaTaxDistribution = value;
			}
        }

		private Boolean _ivaTaxActivityCode;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="iva_tax_activity_code", BaseColumnName ="iva_tax_activity_code", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Boolean IvaTaxActivityCode 
		{ 
		    get { return _ivaTaxActivityCode; } 
			set 
			{
			    _ivaTaxActivityCode = value;
			}
        }

		private Decimal? _ivaTaxIvaValue;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, AllowNull = true, ColumnName ="iva_tax_iva_value", BaseColumnName ="iva_tax_iva_value", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Decimal? IvaTaxIvaValue 
		{ 
		    get { return _ivaTaxIvaValue; } 
			set 
			{
			    _ivaTaxIvaValue = value;
			}
        }

		private Decimal? _ivaTaxMinAmount;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, AllowNull = true, ColumnName ="iva_tax_min_amount", BaseColumnName ="iva_tax_min_amount", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Decimal? IvaTaxMinAmount 
		{ 
		    get { return _ivaTaxMinAmount; } 
			set 
			{
			    _ivaTaxMinAmount = value;
			}
        }

		private Decimal? _ivaTaxMinRate;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, AllowNull = true, ColumnName ="iva_tax_min_rate", BaseColumnName ="iva_tax_min_rate", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Decimal? IvaTaxMinRate 
		{ 
		    get { return _ivaTaxMinRate; } 
			set 
			{
			    _ivaTaxMinRate = value;
			}
        }

		private Decimal? _ivaTaxMaxRate;
		[DataMember]
		[SqlField(DbType.Decimal, 17, Precision = 19, Scale=5, AllowNull = true, ColumnName ="iva_tax_max_rate", BaseColumnName ="iva_tax_max_rate", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Decimal? IvaTaxMaxRate 
		{ 
		    get { return _ivaTaxMaxRate; } 
			set 
			{
			    _ivaTaxMaxRate = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_iva_taxes" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_iva_taxes" )]		
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
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_iva_taxes" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_iva_taxes" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[iva_tax_id], [ou_id], [iva_tax_type], [iva_tax_application_type], [iva_tax_description], [iva_tax_class], [iva_tax_deductible], [iva_tax_foreigner], [iva_tax_deductible_foreigner], [iva_tax_ledger_account], [iva_tax_distribution], [iva_tax_activity_code], [iva_tax_iva_value], [iva_tax_min_amount], [iva_tax_min_rate], [iva_tax_max_rate], [created_date], [created_by], [modified_date], [modified_by]";

	}

	public partial class OrganizationalUnitIvaTaxRepository : Repository<OrganizationalUnitIvaTax> 
	{
		public OrganizationalUnitIvaTaxRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitIvaTax Get(string projectionName, Int32 ivaTaxId)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projectionName, ivaTaxId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitIvaTax Get(string projectionName, Int32 ivaTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projectionName, ivaTaxId, fetchMode);
		}

		public OrganizationalUnitIvaTax Get(Projection projection, Int32 ivaTaxId)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projection, ivaTaxId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitIvaTax Get(Projection projection, Int32 ivaTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projection, ivaTaxId, fetchMode);
		}

		public OrganizationalUnitIvaTax Get(string projectionName, Int32 ivaTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projectionName, ivaTaxId, fields);
		}

		public OrganizationalUnitIvaTax Get(Projection projection, Int32 ivaTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).Get(projection, ivaTaxId, fields);
		}

		public bool Delete(Int32 ivaTaxId)
		{
			var entity = new OrganizationalUnitIvaTax { IvaTaxId = ivaTaxId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(string projectionName, Int32 ivaTaxId)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projectionName, ivaTaxId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(string projectionName, Int32 ivaTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projectionName, ivaTaxId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(Projection projection, Int32 ivaTaxId)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projection, ivaTaxId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(Projection projection, Int32 ivaTaxId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projection, ivaTaxId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(string projectionName, Int32 ivaTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projectionName, ivaTaxId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitIvaTax> GetAsync(Projection projection, Int32 ivaTaxId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitIvaTax>)this).GetAsync(projection, ivaTaxId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ivaTaxId)
		{
			var entity = new OrganizationalUnitIvaTax { IvaTaxId = ivaTaxId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitIvaTaxFields
	{
		public const string IvaTaxId = "IvaTaxId";
		public const string OuId = "OuId";
		public const string IvaTaxType = "IvaTaxType";
		public const string IvaTaxApplicationType = "IvaTaxApplicationType";
		public const string IvaTaxDescription = "IvaTaxDescription";
		public const string IvaTaxClass = "IvaTaxClass";
		public const string IvaTaxDeductible = "IvaTaxDeductible";
		public const string IvaTaxForeigner = "IvaTaxForeigner";
		public const string IvaTaxDeductibleForeigner = "IvaTaxDeductibleForeigner";
		public const string IvaTaxLedgerAccount = "IvaTaxLedgerAccount";
		public const string IvaTaxDistribution = "IvaTaxDistribution";
		public const string IvaTaxActivityCode = "IvaTaxActivityCode";
		public const string IvaTaxIvaValue = "IvaTaxIvaValue";
		public const string IvaTaxMinAmount = "IvaTaxMinAmount";
		public const string IvaTaxMinRate = "IvaTaxMinRate";
		public const string IvaTaxMaxRate = "IvaTaxMaxRate";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
	}

	public static partial class OrganizationalUnitIvaTaxProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_unit_mdm_codes")]
	public partial class OrganizationalUnitMdmCode
	{
		private Int32 _ouMdmCodeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, IsAutoincrement=true, IsReadOnly = true, ColumnName ="ou_mdm_code_id", BaseColumnName ="ou_mdm_code_id", BaseTableName = "organizational_unit_mdm_codes" )]		
		public Int32 OuMdmCodeId 
		{ 
		    get { return _ouMdmCodeId; } 
			set 
			{
			    _ouMdmCodeId = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_unit_mdm_codes" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _identifierTypeCode;
		[DataMember]
		[SqlField(DbType.AnsiString, 200, ColumnName ="identifier_type_code", BaseColumnName ="identifier_type_code", BaseTableName = "organizational_unit_mdm_codes" )]		
		public String IdentifierTypeCode 
		{ 
		    get { return _identifierTypeCode; } 
			set 
			{
			    _identifierTypeCode = value;
			}
        }

		private Int32 _ordinal;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ordinal", BaseColumnName ="ordinal", BaseTableName = "organizational_unit_mdm_codes" )]		
		public Int32 Ordinal 
		{ 
		    get { return _ordinal; } 
			set 
			{
			    _ordinal = value;
			}
        }

		private Int32 _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_unit_mdm_codes" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_unit_mdm_codes" )]		
		public DateTime CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32 _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_unit_mdm_codes" )]		
		public Int32 ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private DateTime _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_unit_mdm_codes" )]		
		public DateTime ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[ou_mdm_code_id], [ou_id], [identifier_type_code], [ordinal], [created_by], [created_date], [modified_by], [modified_date]";

	}

	public partial class OrganizationalUnitMdmCodeRepository : Repository<OrganizationalUnitMdmCode> 
	{
		public OrganizationalUnitMdmCodeRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitMdmCode Get(string projectionName, Int32 ouMdmCodeId)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projectionName, ouMdmCodeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitMdmCode Get(string projectionName, Int32 ouMdmCodeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projectionName, ouMdmCodeId, fetchMode);
		}

		public OrganizationalUnitMdmCode Get(Projection projection, Int32 ouMdmCodeId)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projection, ouMdmCodeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitMdmCode Get(Projection projection, Int32 ouMdmCodeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projection, ouMdmCodeId, fetchMode);
		}

		public OrganizationalUnitMdmCode Get(string projectionName, Int32 ouMdmCodeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projectionName, ouMdmCodeId, fields);
		}

		public OrganizationalUnitMdmCode Get(Projection projection, Int32 ouMdmCodeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).Get(projection, ouMdmCodeId, fields);
		}

		public bool Delete(Int32 ouMdmCodeId)
		{
			var entity = new OrganizationalUnitMdmCode { OuMdmCodeId = ouMdmCodeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(string projectionName, Int32 ouMdmCodeId)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projectionName, ouMdmCodeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(string projectionName, Int32 ouMdmCodeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projectionName, ouMdmCodeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(Projection projection, Int32 ouMdmCodeId)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projection, ouMdmCodeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(Projection projection, Int32 ouMdmCodeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projection, ouMdmCodeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(string projectionName, Int32 ouMdmCodeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projectionName, ouMdmCodeId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitMdmCode> GetAsync(Projection projection, Int32 ouMdmCodeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitMdmCode>)this).GetAsync(projection, ouMdmCodeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 ouMdmCodeId)
		{
			var entity = new OrganizationalUnitMdmCode { OuMdmCodeId = ouMdmCodeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitMdmCodeFields
	{
		public const string OuMdmCodeId = "OuMdmCodeId";
		public const string OuId = "OuId";
		public const string IdentifierTypeCode = "IdentifierTypeCode";
		public const string Ordinal = "Ordinal";
		public const string CreatedBy = "CreatedBy";
		public const string CreatedDate = "CreatedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string ModifiedDate = "ModifiedDate";
	}

	public static partial class OrganizationalUnitMdmCodeProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="failure_logins")]
	public partial class FailureLogin
	{
		private Int32 _failureLoginId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, SequenceName = "failure_logins_failure_login_id_seq", ColumnName ="failure_login_id", BaseColumnName ="failure_login_id", BaseTableName = "failure_logins" )]		
		public Int32 FailureLoginId 
		{ 
		    get { return _failureLoginId; } 
			set 
			{
			    _failureLoginId = value;
			}
        }

		private String _domain;
		[DataMember]
		[SqlField(DbType.AnsiString, 100, ColumnName ="domain", BaseColumnName ="domain", BaseTableName = "failure_logins" )]		
		public String Domain 
		{ 
		    get { return _domain; } 
			set 
			{
			    _domain = value;
			}
        }

		private String _username;
		[DataMember]
		[SqlField(DbType.AnsiString, 100, ColumnName ="username", BaseColumnName ="username", BaseTableName = "failure_logins" )]		
		public String Username 
		{ 
		    get { return _username; } 
			set 
			{
			    _username = value;
			}
        }

		private String _errorMessage;
		[DataMember]
		[SqlField(DbType.AnsiString, 500, ColumnName ="error_message", BaseColumnName ="error_message", BaseTableName = "failure_logins" )]		
		public String ErrorMessage 
		{ 
		    get { return _errorMessage; } 
			set 
			{
			    _errorMessage = value;
			}
        }

		private DateTime _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "failure_logins" )]		
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
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "failure_logins" )]		
		public Int32 CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[failure_login_id], [domain], [username], [error_message], [created_date], [created_by]";

	}

	public partial class FailureLoginRepository : Repository<FailureLogin> 
	{
		public FailureLoginRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public FailureLogin Get(string projectionName, Int32 failureLoginId)
		{
			return ((IRepository<FailureLogin>)this).Get(projectionName, failureLoginId, FetchMode.UseIdentityMap);
		}

		public FailureLogin Get(string projectionName, Int32 failureLoginId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FailureLogin>)this).Get(projectionName, failureLoginId, fetchMode);
		}

		public FailureLogin Get(Projection projection, Int32 failureLoginId)
		{
			return ((IRepository<FailureLogin>)this).Get(projection, failureLoginId, FetchMode.UseIdentityMap);
		}

		public FailureLogin Get(Projection projection, Int32 failureLoginId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FailureLogin>)this).Get(projection, failureLoginId, fetchMode);
		}

		public FailureLogin Get(string projectionName, Int32 failureLoginId, params string[] fields)
		{
			return ((IRepository<FailureLogin>)this).Get(projectionName, failureLoginId, fields);
		}

		public FailureLogin Get(Projection projection, Int32 failureLoginId, params string[] fields)
		{
			return ((IRepository<FailureLogin>)this).Get(projection, failureLoginId, fields);
		}

		public bool Delete(Int32 failureLoginId)
		{
			var entity = new FailureLogin { FailureLoginId = failureLoginId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(string projectionName, Int32 failureLoginId)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projectionName, failureLoginId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(string projectionName, Int32 failureLoginId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projectionName, failureLoginId, fetchMode);
		}

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(Projection projection, Int32 failureLoginId)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projection, failureLoginId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(Projection projection, Int32 failureLoginId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projection, failureLoginId, fetchMode);
		}

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(string projectionName, Int32 failureLoginId, params string[] fields)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projectionName, failureLoginId, fields);
		}

		public System.Threading.Tasks.Task<FailureLogin> GetAsync(Projection projection, Int32 failureLoginId, params string[] fields)
		{
			return ((IRepository<FailureLogin>)this).GetAsync(projection, failureLoginId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 failureLoginId)
		{
			var entity = new FailureLogin { FailureLoginId = failureLoginId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class FailureLoginFields
	{
		public const string FailureLoginId = "FailureLoginId";
		public const string Domain = "Domain";
		public const string Username = "Username";
		public const string ErrorMessage = "ErrorMessage";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
	}

	public static partial class FailureLoginProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="permissions")]
	public partial class Permission
	{
		private PermissionId _permissionId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, ColumnName ="permission_id", BaseColumnName ="permission_id", BaseTableName = "permissions" )]		
		public PermissionId PermissionId 
		{ 
		    get { return _permissionId; } 
			set 
			{
			    _permissionId = value;
			}
        }

		private String _permissionNameLocalizable;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="permission_name_localizable", BaseColumnName ="permission_name_localizable", BaseTableName = "permissions" )]		
		public String PermissionNameLocalizable 
		{ 
		    get { return _permissionNameLocalizable; } 
			set 
			{
			    _permissionNameLocalizable = value;
			}
        }

		private String _permissionDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 1000, ColumnName ="permission_description", BaseColumnName ="permission_description", BaseTableName = "permissions" )]		
		public String PermissionDescription 
		{ 
		    get { return _permissionDescription; } 
			set 
			{
			    _permissionDescription = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[permission_id], [permission_name_localizable], [permission_description]";

	}

	public partial class PermissionRepository : Repository<Permission> 
	{
		public PermissionRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public Permission Get(string projectionName, PermissionId permissionId)
		{
			return ((IRepository<Permission>)this).Get(projectionName, permissionId, FetchMode.UseIdentityMap);
		}

		public Permission Get(string projectionName, PermissionId permissionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Permission>)this).Get(projectionName, permissionId, fetchMode);
		}

		public Permission Get(Projection projection, PermissionId permissionId)
		{
			return ((IRepository<Permission>)this).Get(projection, permissionId, FetchMode.UseIdentityMap);
		}

		public Permission Get(Projection projection, PermissionId permissionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Permission>)this).Get(projection, permissionId, fetchMode);
		}

		public Permission Get(string projectionName, PermissionId permissionId, params string[] fields)
		{
			return ((IRepository<Permission>)this).Get(projectionName, permissionId, fields);
		}

		public Permission Get(Projection projection, PermissionId permissionId, params string[] fields)
		{
			return ((IRepository<Permission>)this).Get(projection, permissionId, fields);
		}

		public bool Delete(PermissionId permissionId)
		{
			var entity = new Permission { PermissionId = permissionId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<Permission> GetAsync(string projectionName, PermissionId permissionId)
		{
			return ((IRepository<Permission>)this).GetAsync(projectionName, permissionId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Permission> GetAsync(string projectionName, PermissionId permissionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Permission>)this).GetAsync(projectionName, permissionId, fetchMode);
		}

		public System.Threading.Tasks.Task<Permission> GetAsync(Projection projection, PermissionId permissionId)
		{
			return ((IRepository<Permission>)this).GetAsync(projection, permissionId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<Permission> GetAsync(Projection projection, PermissionId permissionId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<Permission>)this).GetAsync(projection, permissionId, fetchMode);
		}

		public System.Threading.Tasks.Task<Permission> GetAsync(string projectionName, PermissionId permissionId, params string[] fields)
		{
			return ((IRepository<Permission>)this).GetAsync(projectionName, permissionId, fields);
		}

		public System.Threading.Tasks.Task<Permission> GetAsync(Projection projection, PermissionId permissionId, params string[] fields)
		{
			return ((IRepository<Permission>)this).GetAsync(projection, permissionId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(PermissionId permissionId)
		{
			var entity = new Permission { PermissionId = permissionId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class PermissionFields
	{
		public const string PermissionId = "PermissionId";
		public const string PermissionNameLocalizable = "PermissionNameLocalizable";
		public const string PermissionDescription = "PermissionDescription";
	}

	public static partial class PermissionProjections
	{
		public const string BaseTable = "BaseTable";
	}
}

namespace WebApi.Entities.Audit
{
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="organizational_units", SchemaName="audit")]
	public partial class OrganizationalUnitAudit
	{
		private Int32 _auditChangeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, IsAutoincrement=true, IsReadOnly = true, ColumnName ="audit_change_id", BaseColumnName ="audit_change_id", BaseTableName = "organizational_units" )]		
		public Int32 AuditChangeId 
		{ 
		    get { return _auditChangeId; } 
			set 
			{
			    _auditChangeId = value;
			}
        }

		private Int32 _auditUserId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="audit_user_id", BaseColumnName ="audit_user_id", BaseTableName = "organizational_units" )]		
		public Int32 AuditUserId 
		{ 
		    get { return _auditUserId; } 
			set 
			{
			    _auditUserId = value;
			}
        }

		private DateTime _auditChangeDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="audit_change_date", BaseColumnName ="audit_change_date", BaseTableName = "organizational_units" )]		
		public DateTime AuditChangeDate 
		{ 
		    get { return _auditChangeDate; } 
			set 
			{
			    _auditChangeDate = value;
			}
        }

		private String _auditChangeType;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 1, ColumnName ="audit_change_type", BaseColumnName ="audit_change_type", BaseTableName = "organizational_units" )]		
		public String AuditChangeType 
		{ 
		    get { return _auditChangeType; } 
			set 
			{
			    _auditChangeType = value;
			}
        }

		private Int32 _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "organizational_units" )]		
		public Int32 OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _ouName;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="ou_name", BaseColumnName ="ou_name", BaseTableName = "organizational_units" )]		
		public String OuName 
		{ 
		    get { return _ouName; } 
			set 
			{
			    _ouName = value;
			}
        }

		private String _ouDescription;
		[DataMember]
		[SqlField(DbType.String, 1000, ColumnName ="ou_description", BaseColumnName ="ou_description", BaseTableName = "organizational_units" )]		
		public String OuDescription 
		{ 
		    get { return _ouDescription; } 
			set 
			{
			    _ouDescription = value;
			}
        }

		private String _ouCode;
		[DataMember]
		[SqlField(DbType.String, 30, ColumnName ="ou_code", BaseColumnName ="ou_code", BaseTableName = "organizational_units" )]		
		public String OuCode 
		{ 
		    get { return _ouCode; } 
			set 
			{
			    _ouCode = value;
			}
        }

		private DateTime? _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "organizational_units" )]		
		public DateTime? CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32? _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "organizational_units" )]		
		public Int32? CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime? _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "organizational_units" )]		
		public DateTime? ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32? _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "organizational_units" )]		
		public Int32? ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
			}
        }

		private Boolean? _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "organizational_units" )]		
		public Boolean? IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private Int32? _ouParentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_parent_id", BaseColumnName ="ou_parent_id", BaseTableName = "organizational_units" )]		
		public Int32? OuParentId 
		{ 
		    get { return _ouParentId; } 
			set 
			{
			    _ouParentId = value;
			}
        }

		private Int32? _ouTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_type_id", BaseColumnName ="ou_type_id", BaseTableName = "organizational_units" )]		
		public Int32? OuTypeId 
		{ 
		    get { return _ouTypeId; } 
			set 
			{
			    _ouTypeId = value;
			}
        }

		private Boolean? _hasAdvisor;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_advisor", BaseColumnName ="has_advisor", BaseTableName = "organizational_units" )]		
		public Boolean? HasAdvisor 
		{ 
		    get { return _hasAdvisor; } 
			set 
			{
			    _hasAdvisor = value;
			}
        }

		private String _currencySymbol;
		[DataMember]
		[SqlField(DbType.String, 5, ColumnName ="currency_symbol", BaseColumnName ="currency_symbol", BaseTableName = "organizational_units" )]		
		public String CurrencySymbol 
		{ 
		    get { return _currencySymbol; } 
			set 
			{
			    _currencySymbol = value;
			}
        }

		private Boolean? _rightSymbol;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="right_symbol", BaseColumnName ="right_symbol", BaseTableName = "organizational_units" )]		
		public Boolean? RightSymbol 
		{ 
		    get { return _rightSymbol; } 
			set 
			{
			    _rightSymbol = value;
			}
        }

		private Int32? _currencyId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="currency_id", BaseColumnName ="currency_id", BaseTableName = "organizational_units" )]		
		public Int32? CurrencyId 
		{ 
		    get { return _currencyId; } 
			set 
			{
			    _currencyId = value;
			}
        }

		private String _ouCountryCode;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 2, ColumnName ="ou_country_code", BaseColumnName ="ou_country_code", BaseTableName = "organizational_units" )]		
		public String OuCountryCode 
		{ 
		    get { return _ouCountryCode; } 
			set 
			{
			    _ouCountryCode = value;
			}
        }

		private Int32? _departmentId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="department_id", BaseColumnName ="department_id", BaseTableName = "organizational_units" )]		
		public Int32? DepartmentId 
		{ 
		    get { return _departmentId; } 
			set 
			{
			    _departmentId = value;
			}
        }

		private Boolean? _hasOdsSearch;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_ods_search", BaseColumnName ="has_ods_search", BaseTableName = "organizational_units" )]		
		public Boolean? HasOdsSearch 
		{ 
		    get { return _hasOdsSearch; } 
			set 
			{
			    _hasOdsSearch = value;
			}
        }

		private Boolean? _hcoOds;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="hco_ods", BaseColumnName ="hco_ods", BaseTableName = "organizational_units" )]		
		public Boolean? HcoOds 
		{ 
		    get { return _hcoOds; } 
			set 
			{
			    _hcoOds = value;
			}
        }

		private Boolean? _hasLinkZinc;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_link_zinc", BaseColumnName ="has_link_zinc", BaseTableName = "organizational_units" )]		
		public Boolean? HasLinkZinc 
		{ 
		    get { return _hasLinkZinc; } 
			set 
			{
			    _hasLinkZinc = value;
			}
        }

		private Boolean? _allowApprovalPrivateOrganization;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_approval_private_organization", BaseColumnName ="allow_approval_private_organization", BaseTableName = "organizational_units" )]		
		public Boolean? AllowApprovalPrivateOrganization 
		{ 
		    get { return _allowApprovalPrivateOrganization; } 
			set 
			{
			    _allowApprovalPrivateOrganization = value;
			}
        }

		private Boolean _showThirdPartyLogisticsVendorTab;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="show_third_party_logistics_vendor_tab", BaseColumnName ="show_third_party_logistics_vendor_tab", BaseTableName = "organizational_units" )]		
		public Boolean ShowThirdPartyLogisticsVendorTab 
		{ 
		    get { return _showThirdPartyLogisticsVendorTab; } 
			set 
			{
			    _showThirdPartyLogisticsVendorTab = value;
			}
        }

		private Int32? _inputCharactersRemaining;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="input_characters_remaining", BaseColumnName ="input_characters_remaining", BaseTableName = "organizational_units" )]		
		public Int32? InputCharactersRemaining 
		{ 
		    get { return _inputCharactersRemaining; } 
			set 
			{
			    _inputCharactersRemaining = value;
			}
        }

		private Int32? _recipientEntityTypeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="recipient_entity_type_id", BaseColumnName ="recipient_entity_type_id", BaseTableName = "organizational_units" )]		
		public Int32? RecipientEntityTypeId 
		{ 
		    get { return _recipientEntityTypeId; } 
			set 
			{
			    _recipientEntityTypeId = value;
			}
        }

		private Boolean _allowHcoInProfessionalServices;
		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="allow_hco_in_professional_services", BaseColumnName ="allow_hco_in_professional_services", BaseTableName = "organizational_units" )]		
		public Boolean AllowHcoInProfessionalServices 
		{ 
		    get { return _allowHcoInProfessionalServices; } 
			set 
			{
			    _allowHcoInProfessionalServices = value;
			}
        }

		private Boolean? _allowSupportGroupSubmitForms;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_support_group_submit_forms", BaseColumnName ="allow_support_group_submit_forms", BaseTableName = "organizational_units" )]		
		public Boolean? AllowSupportGroupSubmitForms 
		{ 
		    get { return _allowSupportGroupSubmitForms; } 
			set 
			{
			    _allowSupportGroupSubmitForms = value;
			}
        }

		private Boolean? _blockBudgetReconciliation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="block_budget_reconciliation", BaseColumnName ="block_budget_reconciliation", BaseTableName = "organizational_units" )]		
		public Boolean? BlockBudgetReconciliation 
		{ 
		    get { return _blockBudgetReconciliation; } 
			set 
			{
			    _blockBudgetReconciliation = value;
			}
        }

		private Boolean? _allowSelectionAdvisorsDecisionMaker;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_selection_advisors_decision_maker", BaseColumnName ="allow_selection_advisors_decision_maker", BaseTableName = "organizational_units" )]		
		public Boolean? AllowSelectionAdvisorsDecisionMaker 
		{ 
		    get { return _allowSelectionAdvisorsDecisionMaker; } 
			set 
			{
			    _allowSelectionAdvisorsDecisionMaker = value;
			}
        }

		private Boolean? _removeAdvisorInSendBackInitiator;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="remove_advisor_in_send_back_initiator", BaseColumnName ="remove_advisor_in_send_back_initiator", BaseTableName = "organizational_units" )]		
		public Boolean? RemoveAdvisorInSendBackInitiator 
		{ 
		    get { return _removeAdvisorInSendBackInitiator; } 
			set 
			{
			    _removeAdvisorInSendBackInitiator = value;
			}
        }

		private Boolean? _allowChangeAdvisorToDecisionMaker;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_change_advisor_to_decision_maker", BaseColumnName ="allow_change_advisor_to_decision_maker", BaseTableName = "organizational_units" )]		
		public Boolean? AllowChangeAdvisorToDecisionMaker 
		{ 
		    get { return _allowChangeAdvisorToDecisionMaker; } 
			set 
			{
			    _allowChangeAdvisorToDecisionMaker = value;
			}
        }

		private Boolean? _countryWithCertification;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="country_with_certification", BaseColumnName ="country_with_certification", BaseTableName = "organizational_units" )]		
		public Boolean? CountryWithCertification 
		{ 
		    get { return _countryWithCertification; } 
			set 
			{
			    _countryWithCertification = value;
			}
        }

		private Boolean? _rolesSyncWithAd;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="roles_sync_with_ad", BaseColumnName ="roles_sync_with_ad", BaseTableName = "organizational_units" )]		
		public Boolean? RolesSyncWithAd 
		{ 
		    get { return _rolesSyncWithAd; } 
			set 
			{
			    _rolesSyncWithAd = value;
			}
        }

		private String _ntGroupName;
		[DataMember]
		[SqlField(DbType.String, 500, ColumnName ="nt_group_name", BaseColumnName ="nt_group_name", BaseTableName = "organizational_units" )]		
		public String NtGroupName 
		{ 
		    get { return _ntGroupName; } 
			set 
			{
			    _ntGroupName = value;
			}
        }

		private Boolean? _onlyHasApprovalPhase;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="only_has_approval_phase", BaseColumnName ="only_has_approval_phase", BaseTableName = "organizational_units" )]		
		public Boolean? OnlyHasApprovalPhase 
		{ 
		    get { return _onlyHasApprovalPhase; } 
			set 
			{
			    _onlyHasApprovalPhase = value;
			}
        }

		private Boolean? _wbsSelectable;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="wbs_selectable", BaseColumnName ="wbs_selectable", BaseTableName = "organizational_units" )]		
		public Boolean? WbsSelectable 
		{ 
		    get { return _wbsSelectable; } 
			set 
			{
			    _wbsSelectable = value;
			}
        }

		private Boolean? _hasAttendeesExtended;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_attendees_extended", BaseColumnName ="has_attendees_extended", BaseTableName = "organizational_units" )]		
		public Boolean? HasAttendeesExtended 
		{ 
		    get { return _hasAttendeesExtended; } 
			set 
			{
			    _hasAttendeesExtended = value;
			}
        }

		private Boolean? _hasSolicitedUnsolicited;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_solicited_unsolicited", BaseColumnName ="has_solicited_unsolicited", BaseTableName = "organizational_units" )]		
		public Boolean? HasSolicitedUnsolicited 
		{ 
		    get { return _hasSolicitedUnsolicited; } 
			set 
			{
			    _hasSolicitedUnsolicited = value;
			}
        }

		private Boolean? _hasProductProjectActivity;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_product_project_activity", BaseColumnName ="has_product_project_activity", BaseTableName = "organizational_units" )]		
		public Boolean? HasProductProjectActivity 
		{ 
		    get { return _hasProductProjectActivity; } 
			set 
			{
			    _hasProductProjectActivity = value;
			}
        }

		private Boolean? _hasSearchSapProvider;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_search_sap_provider", BaseColumnName ="has_search_sap_provider", BaseTableName = "organizational_units" )]		
		public Boolean? HasSearchSapProvider 
		{ 
		    get { return _hasSearchSapProvider; } 
			set 
			{
			    _hasSearchSapProvider = value;
			}
        }

		private Boolean? _infieldActivity;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="infield_activity", BaseColumnName ="infield_activity", BaseTableName = "organizational_units" )]		
		public Boolean? InfieldActivity 
		{ 
		    get { return _infieldActivity; } 
			set 
			{
			    _infieldActivity = value;
			}
        }

		private Boolean? _hasInternalOrders;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_internal_orders", BaseColumnName ="has_internal_orders", BaseTableName = "organizational_units" )]		
		public Boolean? HasInternalOrders 
		{ 
		    get { return _hasInternalOrders; } 
			set 
			{
			    _hasInternalOrders = value;
			}
        }

		private Boolean? _allGenerateContract;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="all_generate_contract", BaseColumnName ="all_generate_contract", BaseTableName = "organizational_units" )]		
		public Boolean? AllGenerateContract 
		{ 
		    get { return _allGenerateContract; } 
			set 
			{
			    _allGenerateContract = value;
			}
        }

		private Boolean? _hasRecipientsStatusTracking;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_recipients_status_tracking", BaseColumnName ="has_recipients_status_tracking", BaseTableName = "organizational_units" )]		
		public Boolean? HasRecipientsStatusTracking 
		{ 
		    get { return _hasRecipientsStatusTracking; } 
			set 
			{
			    _hasRecipientsStatusTracking = value;
			}
        }

		private Boolean? _hasSignedContracts;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_signed_contracts", BaseColumnName ="has_signed_contracts", BaseTableName = "organizational_units" )]		
		public Boolean? HasSignedContracts 
		{ 
		    get { return _hasSignedContracts; } 
			set 
			{
			    _hasSignedContracts = value;
			}
        }

		private Boolean? _activateEventsModule;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="activate_events_module", BaseColumnName ="activate_events_module", BaseTableName = "organizational_units" )]		
		public Boolean? ActivateEventsModule 
		{ 
		    get { return _activateEventsModule; } 
			set 
			{
			    _activateEventsModule = value;
			}
        }

		private Boolean? _allowSupportGroupToCancelForms;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="allow_support_group_to_cancel_forms", BaseColumnName ="allow_support_group_to_cancel_forms", BaseTableName = "organizational_units" )]		
		public Boolean? AllowSupportGroupToCancelForms 
		{ 
		    get { return _allowSupportGroupToCancelForms; } 
			set 
			{
			    _allowSupportGroupToCancelForms = value;
			}
        }

		private Boolean? _selectLoadModeRecipientsDetails;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="select_load_mode_recipients_details", BaseColumnName ="select_load_mode_recipients_details", BaseTableName = "organizational_units" )]		
		public Boolean? SelectLoadModeRecipientsDetails 
		{ 
		    get { return _selectLoadModeRecipientsDetails; } 
			set 
			{
			    _selectLoadModeRecipientsDetails = value;
			}
        }

		private Boolean? _isOdsLocal;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_ods_local", BaseColumnName ="is_ods_local", BaseTableName = "organizational_units" )]		
		public Boolean? IsOdsLocal 
		{ 
		    get { return _isOdsLocal; } 
			set 
			{
			    _isOdsLocal = value;
			}
        }

		private Boolean? _isEnableDisableAutomaticContractingTool;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_enable_disable_automatic_contracting_tool", BaseColumnName ="is_enable_disable_automatic_contracting_tool", BaseTableName = "organizational_units" )]		
		public Boolean? IsEnableDisableAutomaticContractingTool 
		{ 
		    get { return _isEnableDisableAutomaticContractingTool; } 
			set 
			{
			    _isEnableDisableAutomaticContractingTool = value;
			}
        }

		private Boolean? _additionalApprovalBeforeCloseout;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="additional_approval_before_closeout", BaseColumnName ="additional_approval_before_closeout", BaseTableName = "organizational_units" )]		
		public Boolean? AdditionalApprovalBeforeCloseout 
		{ 
		    get { return _additionalApprovalBeforeCloseout; } 
			set 
			{
			    _additionalApprovalBeforeCloseout = value;
			}
        }

		private Boolean? _isSapLocal;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_sap_local", BaseColumnName ="is_sap_local", BaseTableName = "organizational_units" )]		
		public Boolean? IsSapLocal 
		{ 
		    get { return _isSapLocal; } 
			set 
			{
			    _isSapLocal = value;
			}
        }

		private Boolean? _hasLogisticalArrangementsExtended;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_logistical_arrangements_extended", BaseColumnName ="has_logistical_arrangements_extended", BaseTableName = "organizational_units" )]		
		public Boolean? HasLogisticalArrangementsExtended 
		{ 
		    get { return _hasLogisticalArrangementsExtended; } 
			set 
			{
			    _hasLogisticalArrangementsExtended = value;
			}
        }

		private Int32? _additionalApprovalBeforeCloseoutRolId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="additional_approval_before_closeout_rol_id", BaseColumnName ="additional_approval_before_closeout_rol_id", BaseTableName = "organizational_units" )]		
		public Int32? AdditionalApprovalBeforeCloseoutRolId 
		{ 
		    get { return _additionalApprovalBeforeCloseoutRolId; } 
			set 
			{
			    _additionalApprovalBeforeCloseoutRolId = value;
			}
        }

		private Boolean? _isOuAllergan;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_ou_allergan", BaseColumnName ="is_ou_allergan", BaseTableName = "organizational_units" )]		
		public Boolean? IsOuAllergan 
		{ 
		    get { return _isOuAllergan; } 
			set 
			{
			    _isOuAllergan = value;
			}
        }

		private Boolean? _isCrossBorderHost;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_cross_border_host", BaseColumnName ="is_cross_border_host", BaseTableName = "organizational_units" )]		
		public Boolean? IsCrossBorderHost 
		{ 
		    get { return _isCrossBorderHost; } 
			set 
			{
			    _isCrossBorderHost = value;
			}
        }

		private Boolean? _isCrossBorderHome;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_cross_border_home", BaseColumnName ="is_cross_border_home", BaseTableName = "organizational_units" )]		
		public Boolean? IsCrossBorderHome 
		{ 
		    get { return _isCrossBorderHome; } 
			set 
			{
			    _isCrossBorderHome = value;
			}
        }

		private Boolean? _isCrossBorder;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_cross_border", BaseColumnName ="is_cross_border", BaseTableName = "organizational_units" )]		
		public Boolean? IsCrossBorder 
		{ 
		    get { return _isCrossBorder; } 
			set 
			{
			    _isCrossBorder = value;
			}
        }

		private Boolean? _hasMassiveUploadAssistants;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_massive_upload_assistants", BaseColumnName ="has_massive_upload_assistants", BaseTableName = "organizational_units" )]		
		public Boolean? HasMassiveUploadAssistants 
		{ 
		    get { return _hasMassiveUploadAssistants; } 
			set 
			{
			    _hasMassiveUploadAssistants = value;
			}
        }

		private Boolean? _hasInvitationLettersAssistants;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_invitation_letters_assistants", BaseColumnName ="has_invitation_letters_assistants", BaseTableName = "organizational_units" )]		
		public Boolean? HasInvitationLettersAssistants 
		{ 
		    get { return _hasInvitationLettersAssistants; } 
			set 
			{
			    _hasInvitationLettersAssistants = value;
			}
        }

		private Boolean? _hasPsExtendedGeneric;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_ps_extended_generic", BaseColumnName ="has_ps_extended_generic", BaseTableName = "organizational_units" )]		
		public Boolean? HasPsExtendedGeneric 
		{ 
		    get { return _hasPsExtendedGeneric; } 
			set 
			{
			    _hasPsExtendedGeneric = value;
			}
        }

		private Boolean? _hasLogisticalReconciliation;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_logistical_reconciliation", BaseColumnName ="has_logistical_reconciliation", BaseTableName = "organizational_units" )]		
		public Boolean? HasLogisticalReconciliation 
		{ 
		    get { return _hasLogisticalReconciliation; } 
			set 
			{
			    _hasLogisticalReconciliation = value;
			}
        }

		private Boolean? _hasFinancialData;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_financial_data", BaseColumnName ="has_financial_data", BaseTableName = "organizational_units" )]		
		public Boolean? HasFinancialData 
		{ 
		    get { return _hasFinancialData; } 
			set 
			{
			    _hasFinancialData = value;
			}
        }

		private Boolean? _useMdm;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="use_mdm", BaseColumnName ="use_mdm", BaseTableName = "organizational_units" )]		
		public Boolean? UseMdm 
		{ 
		    get { return _useMdm; } 
			set 
			{
			    _useMdm = value;
			}
        }

		private Boolean? _hasAllerganContractTemplate;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="has_allergan_contract_template", BaseColumnName ="has_allergan_contract_template", BaseTableName = "organizational_units" )]		
		public Boolean? HasAllerganContractTemplate 
		{ 
		    get { return _hasAllerganContractTemplate; } 
			set 
			{
			    _hasAllerganContractTemplate = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[audit_change_id], [audit_user_id], [audit_change_date], [audit_change_type], [ou_id], [ou_name], [ou_description], [ou_code], [created_date], [created_by], [modified_date], [modified_by], [is_active], [ou_parent_id], [ou_type_id], [has_advisor], [currency_symbol], [right_symbol], [currency_id], [ou_country_code], [department_id], [has_ods_search], [hco_ods], [has_link_zinc], [allow_approval_private_organization], [show_third_party_logistics_vendor_tab], [input_characters_remaining], [recipient_entity_type_id], [allow_hco_in_professional_services], [allow_support_group_submit_forms], [block_budget_reconciliation], [allow_selection_advisors_decision_maker], [remove_advisor_in_send_back_initiator], [allow_change_advisor_to_decision_maker], [country_with_certification], [roles_sync_with_ad], [nt_group_name], [only_has_approval_phase], [wbs_selectable], [has_attendees_extended], [has_solicited_unsolicited], [has_product_project_activity], [has_search_sap_provider], [infield_activity], [has_internal_orders], [all_generate_contract], [has_recipients_status_tracking], [has_signed_contracts], [activate_events_module], [allow_support_group_to_cancel_forms], [select_load_mode_recipients_details], [is_ods_local], [is_enable_disable_automatic_contracting_tool], [additional_approval_before_closeout], [is_sap_local], [has_logistical_arrangements_extended], [additional_approval_before_closeout_rol_id], [is_ou_allergan], [is_cross_border_host], [is_cross_border_home], [is_cross_border], [has_massive_upload_assistants], [has_invitation_letters_assistants], [has_ps_extended_generic], [has_logistical_reconciliation], [has_financial_data], [use_mdm], [has_allergan_contract_template]";

	}

	public partial class OrganizationalUnitAuditRepository : Repository<OrganizationalUnitAudit> 
	{
		public OrganizationalUnitAuditRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public OrganizationalUnitAudit Get(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitAudit Get(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projectionName, auditChangeId, fetchMode);
		}

		public OrganizationalUnitAudit Get(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public OrganizationalUnitAudit Get(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projection, auditChangeId, fetchMode);
		}

		public OrganizationalUnitAudit Get(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projectionName, auditChangeId, fields);
		}

		public OrganizationalUnitAudit Get(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).Get(projection, auditChangeId, fields);
		}

		public bool Delete(Int32 auditChangeId)
		{
			var entity = new OrganizationalUnitAudit { AuditChangeId = auditChangeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projectionName, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projection, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projectionName, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<OrganizationalUnitAudit> GetAsync(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<OrganizationalUnitAudit>)this).GetAsync(projection, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 auditChangeId)
		{
			var entity = new OrganizationalUnitAudit { AuditChangeId = auditChangeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class OrganizationalUnitAuditFields
	{
		public const string AuditChangeId = "AuditChangeId";
		public const string AuditUserId = "AuditUserId";
		public const string AuditChangeDate = "AuditChangeDate";
		public const string AuditChangeType = "AuditChangeType";
		public const string OuId = "OuId";
		public const string OuName = "OuName";
		public const string OuDescription = "OuDescription";
		public const string OuCode = "OuCode";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string IsActive = "IsActive";
		public const string OuParentId = "OuParentId";
		public const string OuTypeId = "OuTypeId";
		public const string HasAdvisor = "HasAdvisor";
		public const string CurrencySymbol = "CurrencySymbol";
		public const string RightSymbol = "RightSymbol";
		public const string CurrencyId = "CurrencyId";
		public const string OuCountryCode = "OuCountryCode";
		public const string DepartmentId = "DepartmentId";
		public const string HasOdsSearch = "HasOdsSearch";
		public const string HcoOds = "HcoOds";
		public const string HasLinkZinc = "HasLinkZinc";
		public const string AllowApprovalPrivateOrganization = "AllowApprovalPrivateOrganization";
		public const string ShowThirdPartyLogisticsVendorTab = "ShowThirdPartyLogisticsVendorTab";
		public const string InputCharactersRemaining = "InputCharactersRemaining";
		public const string RecipientEntityTypeId = "RecipientEntityTypeId";
		public const string AllowHcoInProfessionalServices = "AllowHcoInProfessionalServices";
		public const string AllowSupportGroupSubmitForms = "AllowSupportGroupSubmitForms";
		public const string BlockBudgetReconciliation = "BlockBudgetReconciliation";
		public const string AllowSelectionAdvisorsDecisionMaker = "AllowSelectionAdvisorsDecisionMaker";
		public const string RemoveAdvisorInSendBackInitiator = "RemoveAdvisorInSendBackInitiator";
		public const string AllowChangeAdvisorToDecisionMaker = "AllowChangeAdvisorToDecisionMaker";
		public const string CountryWithCertification = "CountryWithCertification";
		public const string RolesSyncWithAd = "RolesSyncWithAd";
		public const string NtGroupName = "NtGroupName";
		public const string OnlyHasApprovalPhase = "OnlyHasApprovalPhase";
		public const string WbsSelectable = "WbsSelectable";
		public const string HasAttendeesExtended = "HasAttendeesExtended";
		public const string HasSolicitedUnsolicited = "HasSolicitedUnsolicited";
		public const string HasProductProjectActivity = "HasProductProjectActivity";
		public const string HasSearchSapProvider = "HasSearchSapProvider";
		public const string InfieldActivity = "InfieldActivity";
		public const string HasInternalOrders = "HasInternalOrders";
		public const string AllGenerateContract = "AllGenerateContract";
		public const string HasRecipientsStatusTracking = "HasRecipientsStatusTracking";
		public const string HasSignedContracts = "HasSignedContracts";
		public const string ActivateEventsModule = "ActivateEventsModule";
		public const string AllowSupportGroupToCancelForms = "AllowSupportGroupToCancelForms";
		public const string SelectLoadModeRecipientsDetails = "SelectLoadModeRecipientsDetails";
		public const string IsOdsLocal = "IsOdsLocal";
		public const string IsEnableDisableAutomaticContractingTool = "IsEnableDisableAutomaticContractingTool";
		public const string AdditionalApprovalBeforeCloseout = "AdditionalApprovalBeforeCloseout";
		public const string IsSapLocal = "IsSapLocal";
		public const string HasLogisticalArrangementsExtended = "HasLogisticalArrangementsExtended";
		public const string AdditionalApprovalBeforeCloseoutRolId = "AdditionalApprovalBeforeCloseoutRolId";
		public const string IsOuAllergan = "IsOuAllergan";
		public const string IsCrossBorderHost = "IsCrossBorderHost";
		public const string IsCrossBorderHome = "IsCrossBorderHome";
		public const string IsCrossBorder = "IsCrossBorder";
		public const string HasMassiveUploadAssistants = "HasMassiveUploadAssistants";
		public const string HasInvitationLettersAssistants = "HasInvitationLettersAssistants";
		public const string HasPsExtendedGeneric = "HasPsExtendedGeneric";
		public const string HasLogisticalReconciliation = "HasLogisticalReconciliation";
		public const string HasFinancialData = "HasFinancialData";
		public const string UseMdm = "UseMdm";
		public const string HasAllerganContractTemplate = "HasAllerganContractTemplate";
	}

	public static partial class OrganizationalUnitAuditProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="user_role_entities", SchemaName="audit")]
	public partial class UserRoleEntityAudit
	{
		private Int32 _auditChangeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, IsAutoincrement=true, IsReadOnly = true, ColumnName ="audit_change_id", BaseColumnName ="audit_change_id", BaseTableName = "user_role_entities" )]		
		public Int32 AuditChangeId 
		{ 
		    get { return _auditChangeId; } 
			set 
			{
			    _auditChangeId = value;
			}
        }

		private Int32 _auditUserId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="audit_user_id", BaseColumnName ="audit_user_id", BaseTableName = "user_role_entities" )]		
		public Int32 AuditUserId 
		{ 
		    get { return _auditUserId; } 
			set 
			{
			    _auditUserId = value;
			}
        }

		private DateTime _auditChangeDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="audit_change_date", BaseColumnName ="audit_change_date", BaseTableName = "user_role_entities" )]		
		public DateTime AuditChangeDate 
		{ 
		    get { return _auditChangeDate; } 
			set 
			{
			    _auditChangeDate = value;
			}
        }

		private String _auditChangeType;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 1, ColumnName ="audit_change_type", BaseColumnName ="audit_change_type", BaseTableName = "user_role_entities" )]		
		public String AuditChangeType 
		{ 
		    get { return _auditChangeType; } 
			set 
			{
			    _auditChangeType = value;
			}
        }

		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "user_role_entities" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
			}
        }

		private Int32 _roleId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="role_id", BaseColumnName ="role_id", BaseTableName = "user_role_entities" )]		
		public Int32 RoleId 
		{ 
		    get { return _roleId; } 
			set 
			{
			    _roleId = value;
			}
        }

		private Int32 _entityId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="entity_id", BaseColumnName ="entity_id", BaseTableName = "user_role_entities" )]		
		public Int32 EntityId 
		{ 
		    get { return _entityId; } 
			set 
			{
			    _entityId = value;
			}
        }

		private DateTime? _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "user_role_entities" )]		
		public DateTime? CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32? _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "user_role_entities" )]		
		public Int32? CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private String _jobDescription;
		[DataMember]
		[SqlField(DbType.AnsiString, 256, ColumnName ="job_description", BaseColumnName ="job_description", BaseTableName = "user_role_entities" )]		
		public String JobDescription 
		{ 
		    get { return _jobDescription; } 
			set 
			{
			    _jobDescription = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[audit_change_id], [audit_user_id], [audit_change_date], [audit_change_type], [user_id], [role_id], [entity_id], [created_date], [created_by], [job_description]";

	}

	public partial class UserRoleEntityAuditRepository : Repository<UserRoleEntityAudit> 
	{
		public UserRoleEntityAuditRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public UserRoleEntityAudit Get(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public UserRoleEntityAudit Get(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projectionName, auditChangeId, fetchMode);
		}

		public UserRoleEntityAudit Get(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public UserRoleEntityAudit Get(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projection, auditChangeId, fetchMode);
		}

		public UserRoleEntityAudit Get(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projectionName, auditChangeId, fields);
		}

		public UserRoleEntityAudit Get(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserRoleEntityAudit>)this).Get(projection, auditChangeId, fields);
		}

		public bool Delete(Int32 auditChangeId)
		{
			var entity = new UserRoleEntityAudit { AuditChangeId = auditChangeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projectionName, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projection, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projectionName, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<UserRoleEntityAudit> GetAsync(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserRoleEntityAudit>)this).GetAsync(projection, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 auditChangeId)
		{
			var entity = new UserRoleEntityAudit { AuditChangeId = auditChangeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class UserRoleEntityAuditFields
	{
		public const string AuditChangeId = "AuditChangeId";
		public const string AuditUserId = "AuditUserId";
		public const string AuditChangeDate = "AuditChangeDate";
		public const string AuditChangeType = "AuditChangeType";
		public const string UserId = "UserId";
		public const string RoleId = "RoleId";
		public const string EntityId = "EntityId";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string JobDescription = "JobDescription";
	}

	public static partial class UserRoleEntityAuditProjections
	{
		public const string BaseTable = "BaseTable";
	}
	[Serializable]
	[DataContract]
    [TypeScript] 
	[SqlEntity(BaseTableName="users", SchemaName="audit")]
	public partial class UserAudit
	{
		private Int32 _auditChangeId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, IsAutoincrement=true, IsReadOnly = true, ColumnName ="audit_change_id", BaseColumnName ="audit_change_id", BaseTableName = "users" )]		
		public Int32 AuditChangeId 
		{ 
		    get { return _auditChangeId; } 
			set 
			{
			    _auditChangeId = value;
			}
        }

		private Int32 _auditUserId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="audit_user_id", BaseColumnName ="audit_user_id", BaseTableName = "users" )]		
		public Int32 AuditUserId 
		{ 
		    get { return _auditUserId; } 
			set 
			{
			    _auditUserId = value;
			}
        }

		private DateTime _auditChangeDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="audit_change_date", BaseColumnName ="audit_change_date", BaseTableName = "users" )]		
		public DateTime AuditChangeDate 
		{ 
		    get { return _auditChangeDate; } 
			set 
			{
			    _auditChangeDate = value;
			}
        }

		private String _auditChangeType;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 1, ColumnName ="audit_change_type", BaseColumnName ="audit_change_type", BaseTableName = "users" )]		
		public String AuditChangeType 
		{ 
		    get { return _auditChangeType; } 
			set 
			{
			    _auditChangeType = value;
			}
        }

		private Int32 _userId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="user_id", BaseColumnName ="user_id", BaseTableName = "users" )]		
		public Int32 UserId 
		{ 
		    get { return _userId; } 
			set 
			{
			    _userId = value;
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

		private String _userMail;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="user_mail", BaseColumnName ="user_mail", BaseTableName = "users" )]		
		public String UserMail 
		{ 
		    get { return _userMail; } 
			set 
			{
			    _userMail = value;
			}
        }

		private Boolean? _isActive;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="is_active", BaseColumnName ="is_active", BaseTableName = "users" )]		
		public Boolean? IsActive 
		{ 
		    get { return _isActive; } 
			set 
			{
			    _isActive = value;
			}
        }

		private DateTime? _createdDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="created_date", BaseColumnName ="created_date", BaseTableName = "users" )]		
		public DateTime? CreatedDate 
		{ 
		    get { return _createdDate; } 
			set 
			{
			    _createdDate = value;
			}
        }

		private Int32? _createdBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="created_by", BaseColumnName ="created_by", BaseTableName = "users" )]		
		public Int32? CreatedBy 
		{ 
		    get { return _createdBy; } 
			set 
			{
			    _createdBy = value;
			}
        }

		private DateTime? _modifiedDate;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="modified_date", BaseColumnName ="modified_date", BaseTableName = "users" )]		
		public DateTime? ModifiedDate 
		{ 
		    get { return _modifiedDate; } 
			set 
			{
			    _modifiedDate = value;
			}
        }

		private Int32? _modifiedBy;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="modified_by", BaseColumnName ="modified_by", BaseTableName = "users" )]		
		public Int32? ModifiedBy 
		{ 
		    get { return _modifiedBy; } 
			set 
			{
			    _modifiedBy = value;
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

		private String _cultureCode;
		[DataMember]
		[SqlField(DbType.AnsiStringFixedLength, 5, ColumnName ="culture_code", BaseColumnName ="culture_code", BaseTableName = "users" )]		
		public String CultureCode 
		{ 
		    get { return _cultureCode; } 
			set 
			{
			    _cultureCode = value;
			}
        }

		private String _upi;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="upi", BaseColumnName ="upi", BaseTableName = "users" )]		
		public String Upi 
		{ 
		    get { return _upi; } 
			set 
			{
			    _upi = value;
			}
        }

		private Int32? _ouId;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="ou_id", BaseColumnName ="ou_id", BaseTableName = "users" )]		
		public Int32? OuId 
		{ 
		    get { return _ouId; } 
			set 
			{
			    _ouId = value;
			}
        }

		private String _title;
		[DataMember]
		[SqlField(DbType.AnsiString, 128, ColumnName ="title", BaseColumnName ="title", BaseTableName = "users" )]		
		public String Title 
		{ 
		    get { return _title; } 
			set 
			{
			    _title = value;
			}
        }

		private Boolean? _hideProcessHistory;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="hide_process_history", BaseColumnName ="hide_process_history", BaseTableName = "users" )]		
		public Boolean? HideProcessHistory 
		{ 
		    get { return _hideProcessHistory; } 
			set 
			{
			    _hideProcessHistory = value;
			}
        }

		private Boolean? _seeCompactView;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="see_compact_view", BaseColumnName ="see_compact_view", BaseTableName = "users" )]		
		public Boolean? SeeCompactView 
		{ 
		    get { return _seeCompactView; } 
			set 
			{
			    _seeCompactView = value;
			}
        }

		private Int32? _loginFailedAttemptsCount;
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="login_failed_attempts_count", BaseColumnName ="login_failed_attempts_count", BaseTableName = "users" )]		
		public Int32? LoginFailedAttemptsCount 
		{ 
		    get { return _loginFailedAttemptsCount; } 
			set 
			{
			    _loginFailedAttemptsCount = value;
			}
        }

		private DateTime? _lastLoginAttempt;
		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="last_login_attempt", BaseColumnName ="last_login_attempt", BaseTableName = "users" )]		
		public DateTime? LastLoginAttempt 
		{ 
		    get { return _lastLoginAttempt; } 
			set 
			{
			    _lastLoginAttempt = value;
			}
        }

		private Boolean? _hideAudit;
		[DataMember]
		[SqlField(DbType.Boolean, 1, AllowNull = true, ColumnName ="hide_audit", BaseColumnName ="hide_audit", BaseTableName = "users" )]		
		public Boolean? HideAudit 
		{ 
		    get { return _hideAudit; } 
			set 
			{
			    _hideAudit = value;
			}
        }

		private String _division;
		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="division", BaseColumnName ="division", BaseTableName = "users" )]		
		public String Division 
		{ 
		    get { return _division; } 
			set 
			{
			    _division = value;
			}
        }

		public const string BaseTableProjectionColumnList = "[audit_change_id], [audit_user_id], [audit_change_date], [audit_change_type], [user_id], [user_name], [user_mail], [is_active], [created_date], [created_by], [modified_date], [modified_by], [login_name], [culture_code], [upi], [ou_id], [title], [hide_process_history], [see_compact_view], [login_failed_attempts_count], [last_login_attempt], [hide_audit], [division]";

	}

	public partial class UserAuditRepository : Repository<UserAudit> 
	{
		public UserAuditRepository(DataService DataService) : base(DataService)
		{
		}

		public new MapDataService  DataService  
		{
			get { return (MapDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public UserAudit Get(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<UserAudit>)this).Get(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public UserAudit Get(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserAudit>)this).Get(projectionName, auditChangeId, fetchMode);
		}

		public UserAudit Get(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<UserAudit>)this).Get(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public UserAudit Get(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserAudit>)this).Get(projection, auditChangeId, fetchMode);
		}

		public UserAudit Get(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserAudit>)this).Get(projectionName, auditChangeId, fields);
		}

		public UserAudit Get(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserAudit>)this).Get(projection, auditChangeId, fields);
		}

		public bool Delete(Int32 auditChangeId)
		{
			var entity = new UserAudit { AuditChangeId = auditChangeId };
			return this.Delete(entity);
		}

				// asyncrhonous methods

		public System.Threading.Tasks.Task<UserAudit> GetAsync(string projectionName, Int32 auditChangeId)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projectionName, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserAudit> GetAsync(string projectionName, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projectionName, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserAudit> GetAsync(Projection projection, Int32 auditChangeId)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projection, auditChangeId, FetchMode.UseIdentityMap);
		}

		public System.Threading.Tasks.Task<UserAudit> GetAsync(Projection projection, Int32 auditChangeId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projection, auditChangeId, fetchMode);
		}

		public System.Threading.Tasks.Task<UserAudit> GetAsync(string projectionName, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projectionName, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<UserAudit> GetAsync(Projection projection, Int32 auditChangeId, params string[] fields)
		{
			return ((IRepository<UserAudit>)this).GetAsync(projection, auditChangeId, fields);
		}

		public System.Threading.Tasks.Task<bool> DeleteAsync(Int32 auditChangeId)
		{
			var entity = new UserAudit { AuditChangeId = auditChangeId };
			return this.DeleteAsync(entity);
		}
			}
	// [Obsolete("Use nameof instead")]
	public static partial class UserAuditFields
	{
		public const string AuditChangeId = "AuditChangeId";
		public const string AuditUserId = "AuditUserId";
		public const string AuditChangeDate = "AuditChangeDate";
		public const string AuditChangeType = "AuditChangeType";
		public const string UserId = "UserId";
		public const string UserName = "UserName";
		public const string UserMail = "UserMail";
		public const string IsActive = "IsActive";
		public const string CreatedDate = "CreatedDate";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedDate = "ModifiedDate";
		public const string ModifiedBy = "ModifiedBy";
		public const string LoginName = "LoginName";
		public const string CultureCode = "CultureCode";
		public const string Upi = "Upi";
		public const string OuId = "OuId";
		public const string Title = "Title";
		public const string HideProcessHistory = "HideProcessHistory";
		public const string SeeCompactView = "SeeCompactView";
		public const string LoginFailedAttemptsCount = "LoginFailedAttemptsCount";
		public const string LastLoginAttempt = "LastLoginAttempt";
		public const string HideAudit = "HideAudit";
		public const string Division = "Division";
	}

	public static partial class UserAuditProjections
	{
		public const string BaseTable = "BaseTable";
	}
}

namespace WebApi.Entities
{
	[TypeScript] 
	public enum RoleId
	{
		Advisor = 2,
		AreaFunctionalAdmin = 8,
		AreaSecurityAdmin = 9,
		BusinessSupport = 16,
		CountryFunctionalAdmin = 10,
		CountrySecurityAdmin = 11,
		CountrySecurityLead = 20,
		CrossBorderAdmin = 26,
		DecisionMaker = 3,
		GlobalFunctionalAdmin = 12,
		GlobalSecurityAdmin = 13,
		Initiator = 1,
		Legal = 19,
		Notifier = 14,
		Oec = 4,
		OecPlus = 18,
		PlaneaAdministrator = 24,
		PlaneaBusinessPlansUser = 21,
		PlaneaConsultation = 23,
		PlaneaFinancialPlanning = 22,
		ProductOwner = 25,
		SecondAdvisor = 15,
		SupportGroup = 5,
		System = 7,
		Validator = 17,
		Viewer = 6,
	}
	[TypeScript] 
	public enum PermissionId
	{
		Activities = 1,
		AdminAuditTrail = 16,
		AdminContracts = 19,
		AdminCostCentersWbs = 18,
		AdminCustomers = 12,
		AdminDataExtraction = 15,
		AdminDelegations = 13,
		AdminEvents = 11,
		AdminHcoSap = 20,
		AdminInternalOrders = 21,
		AdminLogs = 22,
		AdminMaintenance = 9,
		AdminMdm = 42,
		AdminOds = 14,
		AdminOrganizationalUnits = 8,
		AdminProviders = 17,
		AdminTransparency = 39,
		AdminUsers = 7,
		AdminWaivers = 41,
		AdvancedSearch = 23,
		BackofficeAdministration = 5,
		CreateMapFormsHome = 2,
		CrossBorder = 40,
		Dashboard = 4,
		Delegations = 6,
		Events = 24,
		MyTasks = 10,
		Planea = 26,
		PlaneaAccountsConsultation = 32,
		PlaneaBudgetControlSeeAllBrands = 31,
		PlaneaFixAnalysis = 34,
		PlaneaGlobalAdminPlanea = 27,
		PlaneaGlobalPlansAdmin = 35,
		PlaneaSeeMedicalAmountsOnCommercial = 29,
		PlaneaSeeOnlyMyAccounts = 28,
		PlaneaSipAccessWithoutMedicalDepartment = 36,
		PlaneaSipViewAllAccounts = 38,
		PlaneaSipViewAllBrands = 37,
		PlaneaTacticalPlansConsultation = 33,
		PlaneaTacticalPlansEdition = 30,
		Searcher = 3,
		SecurityTracking = 25,
	}
	[TypeScript] 
	public enum EntityTypeId
	{
		Accommodation = 51,
		AccommodationAudit = 91,
		ActivityMenu = 38,
		AppEmail = 45,
		AppEmailAttachment = 48,
		Application = 1,
		AuditEntries = 69,
		AuditEntry = 67,
		Comment = 99,
		Config = 81,
		Consultant = 83,
		ConsultantOrganization = 85,
		Contract = 114,
		ContractComment = 115,
		CostCenterTeam = 119,
		CostReconciliation = 55,
		CostReconciliationCostCenters = 105,
		CostReconciliationInternalOrderNumbers = 106,
		CostReconciliationPayments = 97,
		Currencies = 80,
		Currency = 71,
		Customer = 86,
		CustomerRelationship = 87,
		CustomersCustomerSubType = 95,
		CustomersCustomerSubTypes = 94,
		Delegation = 63,
		DelegationStatuses = 68,
		DonationCost = 102,
		DonationItem = 101,
		EmailAttachment = 46,
		EmailStatus = 47,
		Entity = 9,
		EntityAncestors = 10,
		EntityType = 11,
		Event = 82,
		Figure = 44,
		FileContent = 13,
		FormFileType = 58,
		FormInstance = 23,
		FormInstanceAttendeesAssistant = 103,
		FormInstanceAttendeesOther = 98,
		FormInstanceBusinessPlanRelationship = 296,
		FormInstanceCheck = 65,
		FormInstanceContributionCostOther = 100,
		FormInstanceFile = 14,
		FormInstanceFileVersion = 60,
		FormInstanceIcb = 107,
		FormInstanceIncident = 76,
		FormInstanceInvoice = 116,
		FormInstanceInvoiceComment = 117,
		FormInstanceInvoiceLine = 118,
		FormInstanceJustification = 78,
		FormInstanceLastHistoryEntry = 74,
		FormInstanceRequest = 288,
		FormInstanceSearchItem = 41,
		FormInstanceStatus = 34,
		IcbCostReconciliation = 108,
		IcbCostReconciliationCostCenters = 113,
		IcbCostReconciliationInternalOrderNumbers = 112,
		IcbCostReconciliationPayments = 111,
		ItemType = 35,
		LocalizableText = 17,
		LogisticalArrangementExtended = 278,
		MapCheck = 66,
		MapForm = 15,
		MapFormCategory = 57,
		MapFormCheck = 64,
		MapFormFile = 59,
		MapFormGroup = 75,
		MapFormInstanceStatus = 33,
		MapFormOrganizationalUnit = 56,
		MapFormSection = 21,
		MapFormSectionField = 22,
		MapPhase = 19,
		MapSection = 20,
		Material = 53,
		MaterialAudit = 90,
		Milestone = 287,
		Organization = 84,
		OrganizationalUnit = 12,
		OrganizationalUnitExchangeRate = 72,
		OrganizationalUnitType = 79,
		OuFigure = 43,
		PatientOrganization = 110,
		Permission = 4,
		ProcessHistoryEntry = 49,
		Products = 24,
		ProfessionalService = 52,
		ProfessionalServiceAudit = 92,
		ProfessionalServicesAudit = 88,
		ProfessionalSservicesAudit = 89,
		ProjectBackgroundActivities = 200,
		RecipientDetail = 54,
		ReferenceDataEtag = 16,
		ReferenceTableItem = 36,
		ReferenceTableItemMapForm = 96,
		ReferenceTableItemType = 37,
		Role = 3,
		RolePermission = 5,
		Schedule = 104,
		SponsorshipOther = 73,
		SponsorshipOtherAudit = 93,
		StateMachineTransition = 42,
		SupportedCulture = 40,
		SupportedCultures = 39,
		Text = 18,
		ThirdPartyLogisticsVendor = 109,
		User = 2,
		UserPermission = 8,
		UserRole = 7,
		UserRoleEntity = 6,
		ViewedFileContent = 70,
	}
}

namespace WebApi.Entities
{
	public partial class MapDataService : DataService
	{
		partial void OnCreated();

		private void Init()
		{
			EntityNameToEntityViewTransform = TextTransform.ToUnderscoreLowerCaseNamingConvention;
			EntityLiteProvider.DefaultSchema = "dbo";
			AuditDateTimeKind = DateTimeKind.Utc;
			SequenceSuffix = "_seq";
			OnCreated();
		}

        public MapDataService() : base("Map")
        {
			Init();
        }

        public MapDataService(string connectionStringName) : base(connectionStringName)
        {
			Init();
        }

        public MapDataService(string connectionString, string providerName) : base(connectionString, providerName)
        {
			Init();
        }

		private WebApi.Entities.TextRepository _TextRepository;
		public WebApi.Entities.TextRepository TextRepository
		{
			get 
			{
				if ( _TextRepository == null)
				{
					_TextRepository = new WebApi.Entities.TextRepository(this);
				}
				return _TextRepository;
			}
		}

		private WebApi.Entities.ReferenceDataEtagRepository _ReferenceDataEtagRepository;
		public WebApi.Entities.ReferenceDataEtagRepository ReferenceDataEtagRepository
		{
			get 
			{
				if ( _ReferenceDataEtagRepository == null)
				{
					_ReferenceDataEtagRepository = new WebApi.Entities.ReferenceDataEtagRepository(this);
				}
				return _ReferenceDataEtagRepository;
			}
		}

		private WebApi.Entities.ReferenceTableItemTypeRepository _ReferenceTableItemTypeRepository;
		public WebApi.Entities.ReferenceTableItemTypeRepository ReferenceTableItemTypeRepository
		{
			get 
			{
				if ( _ReferenceTableItemTypeRepository == null)
				{
					_ReferenceTableItemTypeRepository = new WebApi.Entities.ReferenceTableItemTypeRepository(this);
				}
				return _ReferenceTableItemTypeRepository;
			}
		}

		private WebApi.Entities.ReferenceTableItemMapFormRepository _ReferenceTableItemMapFormRepository;
		public WebApi.Entities.ReferenceTableItemMapFormRepository ReferenceTableItemMapFormRepository
		{
			get 
			{
				if ( _ReferenceTableItemMapFormRepository == null)
				{
					_ReferenceTableItemMapFormRepository = new WebApi.Entities.ReferenceTableItemMapFormRepository(this);
				}
				return _ReferenceTableItemMapFormRepository;
			}
		}

		private WebApi.Entities.ReferenceTableItemRepository _ReferenceTableItemRepository;
		public WebApi.Entities.ReferenceTableItemRepository ReferenceTableItemRepository
		{
			get 
			{
				if ( _ReferenceTableItemRepository == null)
				{
					_ReferenceTableItemRepository = new WebApi.Entities.ReferenceTableItemRepository(this);
				}
				return _ReferenceTableItemRepository;
			}
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

		private WebApi.Entities.UserRoleEntityRepository _UserRoleEntityRepository;
		public WebApi.Entities.UserRoleEntityRepository UserRoleEntityRepository
		{
			get 
			{
				if ( _UserRoleEntityRepository == null)
				{
					_UserRoleEntityRepository = new WebApi.Entities.UserRoleEntityRepository(this);
				}
				return _UserRoleEntityRepository;
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

		private WebApi.Entities.UserPermissionRepository _UserPermissionRepository;
		public WebApi.Entities.UserPermissionRepository UserPermissionRepository
		{
			get 
			{
				if ( _UserPermissionRepository == null)
				{
					_UserPermissionRepository = new WebApi.Entities.UserPermissionRepository(this);
				}
				return _UserPermissionRepository;
			}
		}

		private WebApi.Entities.UserRoleOrganizationalUnitRepository _UserRoleOrganizationalUnitRepository;
		public WebApi.Entities.UserRoleOrganizationalUnitRepository UserRoleOrganizationalUnitRepository
		{
			get 
			{
				if ( _UserRoleOrganizationalUnitRepository == null)
				{
					_UserRoleOrganizationalUnitRepository = new WebApi.Entities.UserRoleOrganizationalUnitRepository(this);
				}
				return _UserRoleOrganizationalUnitRepository;
			}
		}

		private WebApi.Entities.UserCriteriaParameterRepository _UserCriteriaParameterRepository;
		public WebApi.Entities.UserCriteriaParameterRepository UserCriteriaParameterRepository
		{
			get 
			{
				if ( _UserCriteriaParameterRepository == null)
				{
					_UserCriteriaParameterRepository = new WebApi.Entities.UserCriteriaParameterRepository(this);
				}
				return _UserCriteriaParameterRepository;
			}
		}

		private WebApi.Entities.EntityRepository _EntityRepository;
		public WebApi.Entities.EntityRepository EntityRepository
		{
			get 
			{
				if ( _EntityRepository == null)
				{
					_EntityRepository = new WebApi.Entities.EntityRepository(this);
				}
				return _EntityRepository;
			}
		}

		private WebApi.Entities.EntityTypeRepository _EntityTypeRepository;
		public WebApi.Entities.EntityTypeRepository EntityTypeRepository
		{
			get 
			{
				if ( _EntityTypeRepository == null)
				{
					_EntityTypeRepository = new WebApi.Entities.EntityTypeRepository(this);
				}
				return _EntityTypeRepository;
			}
		}

		private WebApi.Entities.EntityAncestorsRepository _EntityAncestorsRepository;
		public WebApi.Entities.EntityAncestorsRepository EntityAncestorsRepository
		{
			get 
			{
				if ( _EntityAncestorsRepository == null)
				{
					_EntityAncestorsRepository = new WebApi.Entities.EntityAncestorsRepository(this);
				}
				return _EntityAncestorsRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitRepository _OrganizationalUnitRepository;
		public WebApi.Entities.OrganizationalUnitRepository OrganizationalUnitRepository
		{
			get 
			{
				if ( _OrganizationalUnitRepository == null)
				{
					_OrganizationalUnitRepository = new WebApi.Entities.OrganizationalUnitRepository(this);
				}
				return _OrganizationalUnitRepository;
			}
		}

		private WebApi.Entities.FileContentRepository _FileContentRepository;
		public WebApi.Entities.FileContentRepository FileContentRepository
		{
			get 
			{
				if ( _FileContentRepository == null)
				{
					_FileContentRepository = new WebApi.Entities.FileContentRepository(this);
				}
				return _FileContentRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitTypeRepository _OrganizationalUnitTypeRepository;
		public WebApi.Entities.OrganizationalUnitTypeRepository OrganizationalUnitTypeRepository
		{
			get 
			{
				if ( _OrganizationalUnitTypeRepository == null)
				{
					_OrganizationalUnitTypeRepository = new WebApi.Entities.OrganizationalUnitTypeRepository(this);
				}
				return _OrganizationalUnitTypeRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitProductRepository _OrganizationalUnitProductRepository;
		public WebApi.Entities.OrganizationalUnitProductRepository OrganizationalUnitProductRepository
		{
			get 
			{
				if ( _OrganizationalUnitProductRepository == null)
				{
					_OrganizationalUnitProductRepository = new WebApi.Entities.OrganizationalUnitProductRepository(this);
				}
				return _OrganizationalUnitProductRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitTeamRepository _OrganizationalUnitTeamRepository;
		public WebApi.Entities.OrganizationalUnitTeamRepository OrganizationalUnitTeamRepository
		{
			get 
			{
				if ( _OrganizationalUnitTeamRepository == null)
				{
					_OrganizationalUnitTeamRepository = new WebApi.Entities.OrganizationalUnitTeamRepository(this);
				}
				return _OrganizationalUnitTeamRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitCarProductRepository _OrganizationalUnitCarProductRepository;
		public WebApi.Entities.OrganizationalUnitCarProductRepository OrganizationalUnitCarProductRepository
		{
			get 
			{
				if ( _OrganizationalUnitCarProductRepository == null)
				{
					_OrganizationalUnitCarProductRepository = new WebApi.Entities.OrganizationalUnitCarProductRepository(this);
				}
				return _OrganizationalUnitCarProductRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitCompanyCodeRepository _OrganizationalUnitCompanyCodeRepository;
		public WebApi.Entities.OrganizationalUnitCompanyCodeRepository OrganizationalUnitCompanyCodeRepository
		{
			get 
			{
				if ( _OrganizationalUnitCompanyCodeRepository == null)
				{
					_OrganizationalUnitCompanyCodeRepository = new WebApi.Entities.OrganizationalUnitCompanyCodeRepository(this);
				}
				return _OrganizationalUnitCompanyCodeRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitContractRepository _OrganizationalUnitContractRepository;
		public WebApi.Entities.OrganizationalUnitContractRepository OrganizationalUnitContractRepository
		{
			get 
			{
				if ( _OrganizationalUnitContractRepository == null)
				{
					_OrganizationalUnitContractRepository = new WebApi.Entities.OrganizationalUnitContractRepository(this);
				}
				return _OrganizationalUnitContractRepository;
			}
		}

		private WebApi.Entities.Audit.OrganizationalUnitAuditRepository _AuditOrganizationalUnitAuditRepository;
		public WebApi.Entities.Audit.OrganizationalUnitAuditRepository AuditOrganizationalUnitAuditRepository
		{
			get 
			{
				if ( _AuditOrganizationalUnitAuditRepository == null)
				{
					_AuditOrganizationalUnitAuditRepository = new WebApi.Entities.Audit.OrganizationalUnitAuditRepository(this);
				}
				return _AuditOrganizationalUnitAuditRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitHcoSapProviderRepository _OrganizationalUnitHcoSapProviderRepository;
		public WebApi.Entities.OrganizationalUnitHcoSapProviderRepository OrganizationalUnitHcoSapProviderRepository
		{
			get 
			{
				if ( _OrganizationalUnitHcoSapProviderRepository == null)
				{
					_OrganizationalUnitHcoSapProviderRepository = new WebApi.Entities.OrganizationalUnitHcoSapProviderRepository(this);
				}
				return _OrganizationalUnitHcoSapProviderRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitSignerRepository _OrganizationalUnitSignerRepository;
		public WebApi.Entities.OrganizationalUnitSignerRepository OrganizationalUnitSignerRepository
		{
			get 
			{
				if ( _OrganizationalUnitSignerRepository == null)
				{
					_OrganizationalUnitSignerRepository = new WebApi.Entities.OrganizationalUnitSignerRepository(this);
				}
				return _OrganizationalUnitSignerRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitAbbvieEntityRepository _OrganizationalUnitAbbvieEntityRepository;
		public WebApi.Entities.OrganizationalUnitAbbvieEntityRepository OrganizationalUnitAbbvieEntityRepository
		{
			get 
			{
				if ( _OrganizationalUnitAbbvieEntityRepository == null)
				{
					_OrganizationalUnitAbbvieEntityRepository = new WebApi.Entities.OrganizationalUnitAbbvieEntityRepository(this);
				}
				return _OrganizationalUnitAbbvieEntityRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitEventTaxRangeRepository _OrganizationalUnitEventTaxRangeRepository;
		public WebApi.Entities.OrganizationalUnitEventTaxRangeRepository OrganizationalUnitEventTaxRangeRepository
		{
			get 
			{
				if ( _OrganizationalUnitEventTaxRangeRepository == null)
				{
					_OrganizationalUnitEventTaxRangeRepository = new WebApi.Entities.OrganizationalUnitEventTaxRangeRepository(this);
				}
				return _OrganizationalUnitEventTaxRangeRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitTerritoryTypeRepository _OrganizationalUnitTerritoryTypeRepository;
		public WebApi.Entities.OrganizationalUnitTerritoryTypeRepository OrganizationalUnitTerritoryTypeRepository
		{
			get 
			{
				if ( _OrganizationalUnitTerritoryTypeRepository == null)
				{
					_OrganizationalUnitTerritoryTypeRepository = new WebApi.Entities.OrganizationalUnitTerritoryTypeRepository(this);
				}
				return _OrganizationalUnitTerritoryTypeRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitTerritoryRepository _OrganizationalUnitTerritoryRepository;
		public WebApi.Entities.OrganizationalUnitTerritoryRepository OrganizationalUnitTerritoryRepository
		{
			get 
			{
				if ( _OrganizationalUnitTerritoryRepository == null)
				{
					_OrganizationalUnitTerritoryRepository = new WebApi.Entities.OrganizationalUnitTerritoryRepository(this);
				}
				return _OrganizationalUnitTerritoryRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitIncomeTaxRepository _OrganizationalUnitIncomeTaxRepository;
		public WebApi.Entities.OrganizationalUnitIncomeTaxRepository OrganizationalUnitIncomeTaxRepository
		{
			get 
			{
				if ( _OrganizationalUnitIncomeTaxRepository == null)
				{
					_OrganizationalUnitIncomeTaxRepository = new WebApi.Entities.OrganizationalUnitIncomeTaxRepository(this);
				}
				return _OrganizationalUnitIncomeTaxRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitIvaTaxRepository _OrganizationalUnitIvaTaxRepository;
		public WebApi.Entities.OrganizationalUnitIvaTaxRepository OrganizationalUnitIvaTaxRepository
		{
			get 
			{
				if ( _OrganizationalUnitIvaTaxRepository == null)
				{
					_OrganizationalUnitIvaTaxRepository = new WebApi.Entities.OrganizationalUnitIvaTaxRepository(this);
				}
				return _OrganizationalUnitIvaTaxRepository;
			}
		}

		private WebApi.Entities.OrganizationalUnitMdmCodeRepository _OrganizationalUnitMdmCodeRepository;
		public WebApi.Entities.OrganizationalUnitMdmCodeRepository OrganizationalUnitMdmCodeRepository
		{
			get 
			{
				if ( _OrganizationalUnitMdmCodeRepository == null)
				{
					_OrganizationalUnitMdmCodeRepository = new WebApi.Entities.OrganizationalUnitMdmCodeRepository(this);
				}
				return _OrganizationalUnitMdmCodeRepository;
			}
		}

		private WebApi.Entities.Audit.UserRoleEntityAuditRepository _AuditUserRoleEntityAuditRepository;
		public WebApi.Entities.Audit.UserRoleEntityAuditRepository AuditUserRoleEntityAuditRepository
		{
			get 
			{
				if ( _AuditUserRoleEntityAuditRepository == null)
				{
					_AuditUserRoleEntityAuditRepository = new WebApi.Entities.Audit.UserRoleEntityAuditRepository(this);
				}
				return _AuditUserRoleEntityAuditRepository;
			}
		}

		private WebApi.Entities.Audit.UserAuditRepository _AuditUserAuditRepository;
		public WebApi.Entities.Audit.UserAuditRepository AuditUserAuditRepository
		{
			get 
			{
				if ( _AuditUserAuditRepository == null)
				{
					_AuditUserAuditRepository = new WebApi.Entities.Audit.UserAuditRepository(this);
				}
				return _AuditUserAuditRepository;
			}
		}

		private WebApi.Entities.FailureLoginRepository _FailureLoginRepository;
		public WebApi.Entities.FailureLoginRepository FailureLoginRepository
		{
			get 
			{
				if ( _FailureLoginRepository == null)
				{
					_FailureLoginRepository = new WebApi.Entities.FailureLoginRepository(this);
				}
				return _FailureLoginRepository;
			}
		}

		private WebApi.Entities.PermissionRepository _PermissionRepository;
		public WebApi.Entities.PermissionRepository PermissionRepository
		{
			get 
			{
				if ( _PermissionRepository == null)
				{
					_PermissionRepository = new WebApi.Entities.PermissionRepository(this);
				}
				return _PermissionRepository;
			}
		}
	}
}
namespace WebApi.Entities
{
	public static partial class StoredProcedures
	{
		public static DbCommand CreateSetContextInfoProcedure(DbConnection connection, string parameterPrefix, string schema = "")
		{
			var cmd = connection.CreateCommand();
			cmd.CommandText = string.IsNullOrEmpty(schema) ? "set_context_info" : schema + "." + "set_context_info";
			cmd.CommandType = CommandType.StoredProcedure;
			IDbDataParameter p = null;

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "RETURN_VALUE";
			p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.ReturnValue;
			p.SourceColumn = "RETURN_VALUE";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "LanguageCode";
			p.DbType = DbType.AnsiStringFixedLength;
            p.Direction = ParameterDirection.Input;
			p.Size = 2;
			p.SourceColumn = "LanguageCode";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "UserId";
			p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.Input;
			p.SourceColumn = "UserId";
			cmd.Parameters.Add(p);

			return cmd;
		}

		public static DbCommand CreateAddAllProductsIntoOuProcedure(DbConnection connection, string parameterPrefix, string schema = "")
		{
			var cmd = connection.CreateCommand();
			cmd.CommandText = string.IsNullOrEmpty(schema) ? "add_all_products_into_ou" : schema + "." + "add_all_products_into_ou";
			cmd.CommandType = CommandType.StoredProcedure;
			IDbDataParameter p = null;

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "RETURN_VALUE";
			p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.ReturnValue;
			p.SourceColumn = "RETURN_VALUE";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "ou_id";
			p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.Input;
			p.SourceColumn = "ou_id";
			cmd.Parameters.Add(p);

			return cmd;
		}

		public static DbCommand CreateUpdateAbbvieEntitiesOusProcedure(DbConnection connection, string parameterPrefix, string schema = "")
		{
			var cmd = connection.CreateCommand();
			cmd.CommandText = string.IsNullOrEmpty(schema) ? "update_abbvie_entities_ous" : schema + "." + "update_abbvie_entities_ous";
			cmd.CommandType = CommandType.StoredProcedure;
			IDbDataParameter p = null;

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "RETURN_VALUE";
			p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.ReturnValue;
			p.SourceColumn = "RETURN_VALUE";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "ou_id";
			p.DbType = DbType.AnsiString;
            p.Direction = ParameterDirection.Input;
			p.Size = 50;
			p.SourceColumn = "ou_id";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "abbvie_entity_ids";
			p.DbType = DbType.AnsiString;
            p.Direction = ParameterDirection.Input;
			p.Size = 256;
			p.SourceColumn = "abbvie_entity_ids";
			cmd.Parameters.Add(p);

			p = cmd.CreateParameter();
			p.ParameterName = parameterPrefix + "createdBy";
			p.DbType = DbType.AnsiString;
            p.Direction = ParameterDirection.Input;
			p.Size = 50;
			p.SourceColumn = "createdBy";
			cmd.Parameters.Add(p);

			return cmd;
		}

	}
}
namespace WebApi.Entities
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
    public partial class TypeScriptAttribute : Attribute
    {
        public static IEnumerable<Type> GetClasses()
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            foreach (var t in asm.GetTypes().Where(x => x.IsClass))
            {
                var attrs = t.GetCustomAttributes(typeof(TypeScriptAttribute), false);
                if (attrs != null && attrs.Length > 0) yield return t;
            }
        }

        public static IEnumerable<Type> GetEnums()
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            foreach (var t in asm.GetTypes().Where(x => x.IsEnum))
            {
                var attrs = t.GetCustomAttributes(typeof(TypeScriptAttribute), false);
                if (attrs != null && attrs.Length > 0) yield return t;
            }
        }
    }
}
