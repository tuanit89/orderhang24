


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace MyDAL{
	public partial class trathainguyenDB{

        public StoredProcedure new_Partner_Add(){
            StoredProcedure sp=new StoredProcedure("new_Partner_Add",this.Provider);
            return sp;
        }
        public StoredProcedure new_Partner_Delete(){
            StoredProcedure sp=new StoredProcedure("new_Partner_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure new_Partner_GetById(){
            StoredProcedure sp=new StoredProcedure("new_Partner_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure new_Partner_GetList_All(){
            StoredProcedure sp=new StoredProcedure("new_Partner_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure new_Partner_Update(){
            StoredProcedure sp=new StoredProcedure("new_Partner_Update",this.Provider);
            return sp;
        }
        public StoredProcedure TagsAdd(){
            StoredProcedure sp=new StoredProcedure("TagsAdd",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_tblUser_Delete(){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_tblUser_GetList_All(){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_tblUser_Update(){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_Update",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_User_Add(){
            StoredProcedure sp=new StoredProcedure("tuan_User_Add",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_User_GetById(){
            StoredProcedure sp=new StoredProcedure("tuan_User_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_user_login(){
            StoredProcedure sp=new StoredProcedure("tuan_user_login",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_user_UpdateProfile(){
            StoredProcedure sp=new StoredProcedure("tuan_user_UpdateProfile",this.Provider);
            return sp;
        }
        public StoredProcedure usp_adviceType_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_adviceType_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_adviceType_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Album_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Album_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Album_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Album_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Add(){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_BoxAd_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_BoxAd_GetList_All(){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Update(){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Add(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_Add(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_Update(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_updateSort(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_updateSort",this.Provider);
            return sp;
        }
        public StoredProcedure usp_carreer_Update(){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_CateType_GetByCateType(){
            StoredProcedure sp=new StoredProcedure("usp_CateType_GetByCateType",this.Provider);
            return sp;
        }
        public StoredProcedure usp_chatbox_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_chatbox_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_chatbox_UpdateActive(){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_UpdateActive",this.Provider);
            return sp;
        }
        public StoredProcedure usp_color_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_color_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_color_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_color_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_color_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_color_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_color_Update(){
            StoredProcedure sp=new StoredProcedure("usp_color_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Contact_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Contact_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Add(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetAllByType(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetAllByType",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Update(){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_updateSort(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_updateSort",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_Add(){
            StoredProcedure sp=new StoredProcedure("usp_news_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_AddPageView(){
            StoredProcedure sp=new StoredProcedure("usp_news_AddPageView",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_news_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_News_GetByCateType(){
            StoredProcedure sp=new StoredProcedure("usp_News_GetByCateType",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList_ByCateType(int pageIndex,int pageSize,string cateType)
        {
            var row = 0;
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_ByCateType",this.Provider);
            sp.Command.AddParameter("PageIndex",pageIndex,DbType.Int16);
            sp.Command.AddParameter("PageSize", pageSize, DbType.Int16);
	        sp.Command.AddParameter("cateType",cateType,DbType.String);
            sp.Command.AddParameter("totalrow", row,DbType.Int16,ParameterDirection.InputOutput);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Home(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Home",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Newest(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Newest",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Relate(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Relate",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Viewest(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Viewest",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetListByTag(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetListByTag",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_Update(){
            StoredProcedure sp=new StoredProcedure("usp_news_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Add(){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Update(){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Add(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Update(){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_nextId(){
            StoredProcedure sp=new StoredProcedure("usp_nextId",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_GetByLatestId(){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetByLatestId",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_updateSort(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_updateSort",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_Add(){
            StoredProcedure sp=new StoredProcedure("usp_product_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_CountAll(){
            StoredProcedure sp=new StoredProcedure("usp_product_CountAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_product_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_GetAllByType(){
            StoredProcedure sp=new StoredProcedure("usp_product_GetAllByType",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_product_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_GETHOME(){
            StoredProcedure sp=new StoredProcedure("usp_product_GETHOME",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_GETHOT(){
            StoredProcedure sp=new StoredProcedure("usp_product_GETHOT",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Product_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Product_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Product_GetListBYCATE(){
            StoredProcedure sp=new StoredProcedure("usp_Product_GetListBYCATE",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_GETRELATE(){
            StoredProcedure sp=new StoredProcedure("usp_product_GETRELATE",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_Search(){
            StoredProcedure sp=new StoredProcedure("usp_product_Search",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_Update(){
            StoredProcedure sp=new StoredProcedure("usp_product_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_UpdateHot(){
            StoredProcedure sp=new StoredProcedure("usp_product_UpdateHot",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Add(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetListByParent(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetListByParent",this.Provider);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Update(){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_productColor_Add(){
            StoredProcedure sp=new StoredProcedure("usp_productColor_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_productColor_GetAllByProduct(){
            StoredProcedure sp=new StoredProcedure("usp_productColor_GetAllByProduct",this.Provider);
            return sp;
        }
        public StoredProcedure usp_productColor_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_productColor_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_productColor_Update(){
            StoredProcedure sp=new StoredProcedure("usp_productColor_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_producType_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_producType_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_GetByKey(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_GetByKey",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Supplier_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Supplier_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Supplier_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Supplier_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Supplier_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_Add(){
            StoredProcedure sp=new StoredProcedure("usp_Support_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_Support_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_GetById(){
            StoredProcedure sp=new StoredProcedure("usp_Support_GetById",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_GetList_All(){
            StoredProcedure sp=new StoredProcedure("usp_Support_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_Update(){
            StoredProcedure sp=new StoredProcedure("usp_Support_Update",this.Provider);
            return sp;
        }
        public StoredProcedure usp_tblUser_Add(){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Add",this.Provider);
            return sp;
        }
        public StoredProcedure usp_tblUser_Delete(){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Delete",this.Provider);
            return sp;
        }
        public StoredProcedure usp_tblUser_GetList_All(){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure usp_tblUser_Update(){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Update",this.Provider);
            return sp;
        }
	
	}
	
}
 