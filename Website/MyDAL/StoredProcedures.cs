


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace MyDAL{
	public partial class trathainguyenDB{

        public StoredProcedure new_Partner_Add(string Name,string Link,string Description,string Image,string Alt){
            StoredProcedure sp=new StoredProcedure("new_Partner_Add",this.Provider);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Link",Link,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("Image",Image,DbType.String);
            sp.Command.AddParameter("Alt",Alt,DbType.String);
            return sp;
        }
        public StoredProcedure new_Partner_Delete(int Id){
            StoredProcedure sp=new StoredProcedure("new_Partner_Delete",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure new_Partner_GetById(int Id){
            StoredProcedure sp=new StoredProcedure("new_Partner_GetById",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure new_Partner_GetList_All(){
            StoredProcedure sp=new StoredProcedure("new_Partner_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure new_Partner_Update(int Id,string Name,string Link,string Description,string Image,string Alt){
            StoredProcedure sp=new StoredProcedure("new_Partner_Update",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Link",Link,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("Image",Image,DbType.String);
            sp.Command.AddParameter("Alt",Alt,DbType.String);
            return sp;
        }
        public StoredProcedure TagsAdd(string tags){
            StoredProcedure sp=new StoredProcedure("TagsAdd",this.Provider);
            sp.Command.AddParameter("tags",tags,DbType.String);
            return sp;
        }
        public StoredProcedure tuan_tblUser_Delete(int id){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure tuan_tblUser_GetList_All(){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure tuan_tblUser_Update(int Id,string Username,string Password,string Fullname,short Status){
            StoredProcedure sp=new StoredProcedure("tuan_tblUser_Update",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Username",Username,DbType.String);
            sp.Command.AddParameter("Password",Password,DbType.String);
            sp.Command.AddParameter("Fullname",Fullname,DbType.String);
            sp.Command.AddParameter("Status",Status,DbType.Int16);
            return sp;
        }
        public StoredProcedure tuan_User_Add(string Username,string Password,string Fullname,short Status){
            StoredProcedure sp=new StoredProcedure("tuan_User_Add",this.Provider);
            sp.Command.AddParameter("Username",Username,DbType.String);
            sp.Command.AddParameter("Password",Password,DbType.String);
            sp.Command.AddParameter("Fullname",Fullname,DbType.String);
            sp.Command.AddParameter("Status",Status,DbType.Int16);
            return sp;
        }
        public StoredProcedure tuan_User_GetById(int id){
            StoredProcedure sp=new StoredProcedure("tuan_User_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure tuan_user_login(string username,string password){
            StoredProcedure sp=new StoredProcedure("tuan_user_login",this.Provider);
            sp.Command.AddParameter("username",username,DbType.String);
            sp.Command.AddParameter("password",password,DbType.String);
            return sp;
        }
        public StoredProcedure tuan_user_UpdateProfile(int id,string username,string password,string fullname){
            StoredProcedure sp=new StoredProcedure("tuan_user_UpdateProfile",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("username",username,DbType.String);
            sp.Command.AddParameter("password",password,DbType.String);
            sp.Command.AddParameter("fullname",fullname,DbType.String);
            return sp;
        }
        public StoredProcedure usp_adviceType_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_adviceType_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_adviceType_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_adviceType_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Album_Add(string title,string description,string image,string altImage,string tag,int sort,bool action,string link){
            StoredProcedure sp=new StoredProcedure("usp_Album_Add",this.Provider);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Album_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Album_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Album_GetAll(int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetAll",this.Provider);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Album_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Album_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_Album_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Album_Update(int id,string title,string description,string image,string altImage,string tag,int sort,bool action,string link){
            StoredProcedure sp=new StoredProcedure("usp_Album_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Add(string Name,string Description,string Link,string Image,int Sort,string Location){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Add",this.Provider);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("Link",Link,DbType.String);
            sp.Command.AddParameter("Image",Image,DbType.String);
            sp.Command.AddParameter("Sort",Sort,DbType.Int32);
            sp.Command.AddParameter("Location",Location,DbType.String);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Delete(int Id){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Delete",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_BoxAd_GetById(int Id){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_GetById",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_BoxAd_GetList_All(string location){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_GetList_All",this.Provider);
            sp.Command.AddParameter("location",location,DbType.String);
            return sp;
        }
        public StoredProcedure usp_BoxAd_Update(int Id,string Name,string Description,string Link,string Image,int Sort,string Location){
            StoredProcedure sp=new StoredProcedure("usp_BoxAd_Update",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("Link",Link,DbType.String);
            sp.Command.AddParameter("Image",Image,DbType.String);
            sp.Command.AddParameter("Sort",Sort,DbType.Int32);
            sp.Command.AddParameter("Location",Location,DbType.String);
            return sp;
        }
        public StoredProcedure usp_carreer_Add(int carreerTypeId,string carreerTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Add",this.Provider);
            sp.Command.AddParameter("carreerTypeId",carreerTypeId,DbType.Int32);
            sp.Command.AddParameter("carreerTypeName",carreerTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_carreer_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_carreer_GetList(int PageIndex,int PageSize,int totalrow,int carreerTypeId){
            StoredProcedure sp=new StoredProcedure("usp_carreer_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("carreerTypeId",carreerTypeId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_Add(string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_Update(int id,string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_carreer_Type_updateSort(int id,int sort){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Type_updateSort",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_carreer_Update(int id,int carreerTypeId,string carreerTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_carreer_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("carreerTypeId",carreerTypeId,DbType.Int32);
            sp.Command.AddParameter("carreerTypeName",carreerTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_CateType_GetByCateType(string CateType){
            StoredProcedure sp=new StoredProcedure("usp_CateType_GetByCateType",this.Provider);
            sp.Command.AddParameter("CateType",CateType,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_chatbox_Delete(int ID){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_Delete",this.Provider);
            sp.Command.AddParameter("ID",ID,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_chatbox_GetById(int ID){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_GetById",this.Provider);
            sp.Command.AddParameter("ID",ID,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_chatbox_UpdateActive(int ID,bool active){
            StoredProcedure sp=new StoredProcedure("usp_chatbox_UpdateActive",this.Provider);
            sp.Command.AddParameter("ID",ID,DbType.Int32);
            sp.Command.AddParameter("active",active,DbType.Boolean);
            return sp;
        }
        public StoredProcedure usp_color_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_color_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_color_GetAll(int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_color_GetAll",this.Provider);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_color_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_color_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_color_Update(int id,string name,string value){
            StoredProcedure sp=new StoredProcedure("usp_color_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("value",value,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Contact_Add(string FullName,string Phone,string Subject,string Message,string Email){
            StoredProcedure sp=new StoredProcedure("usp_Contact_Add",this.Provider);
            sp.Command.AddParameter("FullName",FullName,DbType.String);
            sp.Command.AddParameter("Phone",Phone,DbType.String);
            sp.Command.AddParameter("Subject",Subject,DbType.String);
            sp.Command.AddParameter("Message",Message,DbType.String);
            sp.Command.AddParameter("Email",Email,DbType.String);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Add(int AlbumId,string AlbumName,string images,string altImage){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Add",this.Provider);
            sp.Command.AddParameter("AlbumId",AlbumId,DbType.Int32);
            sp.Command.AddParameter("AlbumName",AlbumName,DbType.String);
            sp.Command.AddParameter("images",images,DbType.AnsiString);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetAllByType(int AlbumId,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetAllByType",this.Provider);
            sp.Command.AddParameter("AlbumId",AlbumId,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_imageAlbum_Update(int id,int AlbumId,string AlbumName,string images,string altImage){
            StoredProcedure sp=new StoredProcedure("usp_imageAlbum_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("AlbumId",AlbumId,DbType.Int32);
            sp.Command.AddParameter("AlbumName",AlbumName,DbType.String);
            sp.Command.AddParameter("images",images,DbType.AnsiString);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Introduction_Add(int introductionTypeId,string introductionTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Add",this.Provider);
            sp.Command.AddParameter("introductionTypeId",introductionTypeId,DbType.Int32);
            sp.Command.AddParameter("introductionTypeName",introductionTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Introduction_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_GetList(int PageIndex,int PageSize,int totalrow,int introductionTypeId){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("introductionTypeId",introductionTypeId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Add(string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_Update(int id,string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Introduction_Type_updateSort(int id,int sort){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Type_updateSort",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Introduction_Update(int id,int introductionTypeId,string introductionTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_Introduction_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("introductionTypeId",introductionTypeId,DbType.Int32);
            sp.Command.AddParameter("introductionTypeName",introductionTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_news_Add(int CateId,string Title,string Description,string content,string image,string AltImage,DateTime CreateDate,string MetaDescription,string link,bool IsAttach,int Sort,string Tags){
            StoredProcedure sp=new StoredProcedure("usp_news_Add",this.Provider);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            sp.Command.AddParameter("Title",Title,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("AltImage",AltImage,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("MetaDescription",MetaDescription,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("IsAttach",IsAttach,DbType.Boolean);
            sp.Command.AddParameter("Sort",Sort,DbType.Int32);
            sp.Command.AddParameter("Tags",Tags,DbType.String);
            return sp;
        }
        public StoredProcedure usp_news_AddPageView(int Id){
            StoredProcedure sp=new StoredProcedure("usp_news_AddPageView",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_news_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_news_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_News_GetByCateType(string CateType){
            StoredProcedure sp=new StoredProcedure("usp_News_GetByCateType",this.Provider);
            sp.Command.AddParameter("CateType",CateType,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_news_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_news_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_news_GetList(int PageIndex,int PageSize,int totalrow,int CateId){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_news_GetList_ByCateType(int PageIndex,int PageSize,int totalrow,string cateType){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_ByCateType",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("cateType",cateType,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Home(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Home",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Newest(int Id,int CateId){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Newest",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Relate(int Id,int CateId){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Relate",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_news_GetList_Viewest(){
            StoredProcedure sp=new StoredProcedure("usp_news_GetList_Viewest",this.Provider);
            return sp;
        }
        public StoredProcedure usp_news_GetListByTag(int PageIndex,int PageSize,int totalrow,string tag){
            StoredProcedure sp=new StoredProcedure("usp_news_GetListByTag",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("tag",tag,DbType.String);
            return sp;
        }
        public StoredProcedure usp_news_Update(int id,int CateId,string title,string description,string content,string image,string altImage,DateTime CreateDate,string link,int Sort,string Tags,bool IsAttach,string MetaDescription){
            StoredProcedure sp=new StoredProcedure("usp_news_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("Sort",Sort,DbType.Int32);
            sp.Command.AddParameter("Tags",Tags,DbType.String);
            sp.Command.AddParameter("IsAttach",IsAttach,DbType.Boolean);
            sp.Command.AddParameter("MetaDescription",MetaDescription,DbType.String);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Add(string CateType,string Name,int Sort,string Description,string MetaDescription,int ParentId,string Link){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Add",this.Provider);
            sp.Command.AddParameter("CateType",CateType,DbType.AnsiString);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Sort",Sort,DbType.Int32);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("MetaDescription",MetaDescription,DbType.String);
            sp.Command.AddParameter("ParentId",ParentId,DbType.Int32);
            sp.Command.AddParameter("Link",Link,DbType.String);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_GetAll(string CateType){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_GetAll",this.Provider);
            sp.Command.AddParameter("CateType",CateType,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_NewsCategory_Update(int id,string name,string link,short sort,string Description,string MetaDescription,string CateType,int ParentId){
            StoredProcedure sp=new StoredProcedure("usp_NewsCategory_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("Description",Description,DbType.String);
            sp.Command.AddParameter("MetaDescription",MetaDescription,DbType.String);
            sp.Command.AddParameter("CateType",CateType,DbType.AnsiString);
            sp.Command.AddParameter("ParentId",ParentId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Add(string title,string description,string content,string tag,string link,string image,int sort,bool action){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Add",this.Provider);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetAll(int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetAll",this.Provider);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_newsPromotion_Update(int id,string title,string description,string content,string tag,string link,string image,int sort,bool action){
            StoredProcedure sp=new StoredProcedure("usp_newsPromotion_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            return sp;
        }
        public StoredProcedure usp_nextId(string tableName){
            StoredProcedure sp=new StoredProcedure("usp_nextId",this.Provider);
            sp.Command.AddParameter("tableName",tableName,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Price_Add(int priceTypeId,string priceTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_Price_Add",this.Provider);
            sp.Command.AddParameter("priceTypeId",priceTypeId,DbType.Int32);
            sp.Command.AddParameter("priceTypeName",priceTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Price_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Price_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_GetByLatestId(){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetByLatestId",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_GetList(int PageIndex,int PageSize,int totalrow,int priceTypeId){
            StoredProcedure sp=new StoredProcedure("usp_Price_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("priceTypeId",priceTypeId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Add(string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_Type_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_Type_Update(int id,string name,string link,short sort,string description,string keyword){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("keyword",keyword,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Price_Type_updateSort(int id,int sort){
            StoredProcedure sp=new StoredProcedure("usp_Price_Type_updateSort",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Price_Update(int id,int priceTypeId,string priceTypeName,string title,string description,string content,string image,string altImage,string tag,DateTime CreateDate,bool action,string link,string desseo){
            StoredProcedure sp=new StoredProcedure("usp_Price_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("priceTypeId",priceTypeId,DbType.Int32);
            sp.Command.AddParameter("priceTypeName",priceTypeName,DbType.String);
            sp.Command.AddParameter("title",title,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("CreateDate",CreateDate,DbType.DateTime);
            sp.Command.AddParameter("action",action,DbType.Boolean);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("desseo",desseo,DbType.String);
            return sp;
        }
        public StoredProcedure usp_product_Add(int CateId,string ProductName,string description,string tag,string image,string altimage,bool IsHot,bool ShowHome,decimal price,string link,string content,int SupplierId,string Model){
            StoredProcedure sp=new StoredProcedure("usp_product_Add",this.Provider);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            sp.Command.AddParameter("ProductName",ProductName,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altimage",altimage,DbType.AnsiString);
            sp.Command.AddParameter("IsHot",IsHot,DbType.Boolean);
            sp.Command.AddParameter("ShowHome",ShowHome,DbType.Boolean);
            sp.Command.AddParameter("price",price,DbType.Currency);
            sp.Command.AddParameter("link",link,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("SupplierId",SupplierId,DbType.Int32);
            sp.Command.AddParameter("Model",Model,DbType.String);
            return sp;
        }
        public StoredProcedure usp_product_CountAll(){
            StoredProcedure sp=new StoredProcedure("usp_product_CountAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_product_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_product_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_GetAllByType(int ProductTypeId,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_product_GetAllByType",this.Provider);
            sp.Command.AddParameter("ProductTypeId",ProductTypeId,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_product_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_GETHOME(int CateId){
            StoredProcedure sp=new StoredProcedure("usp_product_GETHOME",this.Provider);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_GETHOT(){
            StoredProcedure sp=new StoredProcedure("usp_product_GETHOT",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Product_GetList(int PageIndex,int PageSize,int totalrow,int cateid){
            StoredProcedure sp=new StoredProcedure("usp_Product_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("cateid",cateid,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Product_GetListBYCATE(int PageIndex,int PageSize,int totalrow,int cateid){
            StoredProcedure sp=new StoredProcedure("usp_Product_GetListBYCATE",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            sp.Command.AddParameter("cateid",cateid,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_GETRELATE(int cateid,int id){
            StoredProcedure sp=new StoredProcedure("usp_product_GETRELATE",this.Provider);
            sp.Command.AddParameter("cateid",cateid,DbType.Int32);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_Search(string query,int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_product_Search",this.Provider);
            sp.Command.AddParameter("query",query,DbType.String);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_product_Update(int id,int CateId,string ProductName,string description,string tag,string image,string altimage,bool IsHot,bool ShowHome,decimal price,string link,string content,int SupplierId,string Model){
            StoredProcedure sp=new StoredProcedure("usp_product_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("CateId",CateId,DbType.Int32);
            sp.Command.AddParameter("ProductName",ProductName,DbType.String);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("tag",tag,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("altimage",altimage,DbType.AnsiString);
            sp.Command.AddParameter("IsHot",IsHot,DbType.Boolean);
            sp.Command.AddParameter("ShowHome",ShowHome,DbType.Boolean);
            sp.Command.AddParameter("price",price,DbType.Currency);
            sp.Command.AddParameter("link",link,DbType.String);
            sp.Command.AddParameter("content",content,DbType.String);
            sp.Command.AddParameter("SupplierId",SupplierId,DbType.Int32);
            sp.Command.AddParameter("Model",Model,DbType.String);
            return sp;
        }
        public StoredProcedure usp_product_UpdateHot(int id,bool isHot){
            StoredProcedure sp=new StoredProcedure("usp_product_UpdateHot",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("isHot",isHot,DbType.Boolean);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Add(string name,string link,short sort,string metadescription,int parentid,string description,string image){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("metadescription",metadescription,DbType.String);
            sp.Command.AddParameter("parentid",parentid,DbType.Int32);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetAll(int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetAll",this.Provider);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_GetListByParent(int ParentId){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_GetListByParent",this.Provider);
            sp.Command.AddParameter("ParentId",ParentId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_ProductCategory_Update(int id,string name,string link,int sort,string description,string metadescription,int ParentId){
            StoredProcedure sp=new StoredProcedure("usp_ProductCategory_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("metadescription",metadescription,DbType.String);
            sp.Command.AddParameter("ParentId",ParentId,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_productColor_Add(int colorId,string colorValue,int ProductId,string productName,string image,string altImage){
            StoredProcedure sp=new StoredProcedure("usp_productColor_Add",this.Provider);
            sp.Command.AddParameter("colorId",colorId,DbType.Int32);
            sp.Command.AddParameter("colorValue",colorValue,DbType.AnsiString);
            sp.Command.AddParameter("ProductId",ProductId,DbType.Int32);
            sp.Command.AddParameter("productName",productName,DbType.String);
            sp.Command.AddParameter("image",image,DbType.AnsiString);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            return sp;
        }
        public StoredProcedure usp_productColor_GetAllByProduct(int ProductId,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_productColor_GetAllByProduct",this.Provider);
            sp.Command.AddParameter("ProductId",ProductId,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_productColor_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_productColor_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_productColor_Update(int id,int colorId,string colorValue,int ProductId,string productName,string image,string altImage){
            StoredProcedure sp=new StoredProcedure("usp_productColor_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("colorId",colorId,DbType.Int32);
            sp.Command.AddParameter("colorValue",colorValue,DbType.AnsiString);
            sp.Command.AddParameter("ProductId",ProductId,DbType.Int32);
            sp.Command.AddParameter("productName",productName,DbType.String);
            sp.Command.AddParameter("image",image,DbType.AnsiString);
            sp.Command.AddParameter("altImage",altImage,DbType.String);
            return sp;
        }
        public StoredProcedure usp_producType_GetList(int PageIndex,int PageSize,int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_producType_GetList",this.Provider);
            sp.Command.AddParameter("PageIndex",PageIndex,DbType.Int32);
            sp.Command.AddParameter("PageSize",PageSize,DbType.Int32);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Settings_Add(string Key,string Value,string Description){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Add",this.Provider);
            sp.Command.AddParameter("Key",Key,DbType.AnsiString);
            sp.Command.AddParameter("Value",Value,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Settings_Delete(string Key){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Delete",this.Provider);
            sp.Command.AddParameter("Key",Key,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Settings_GetByKey(string Key){
            StoredProcedure sp=new StoredProcedure("usp_Settings_GetByKey",this.Provider);
            sp.Command.AddParameter("Key",Key,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Settings_GetList(){
            StoredProcedure sp=new StoredProcedure("usp_Settings_GetList",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Settings_Update(string Key,string Value,string Description){
            StoredProcedure sp=new StoredProcedure("usp_Settings_Update",this.Provider);
            sp.Command.AddParameter("Key",Key,DbType.AnsiString);
            sp.Command.AddParameter("Value",Value,DbType.String);
            sp.Command.AddParameter("Description",Description,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Slider_Add(string name,string image,string alt,string link){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("image",image,DbType.AnsiString);
            sp.Command.AddParameter("alt",alt,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Slider_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Slider_GetAll(){
            StoredProcedure sp=new StoredProcedure("usp_Slider_GetAll",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Slider_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Slider_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Slider_Update(int id,string name,string image,string alt,string link){
            StoredProcedure sp=new StoredProcedure("usp_Slider_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("image",image,DbType.AnsiString);
            sp.Command.AddParameter("alt",alt,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Supplier_Add(string name,string link,short sort,string metadescription,int parentid,string description,string image,string HasCateId){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Add",this.Provider);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int16);
            sp.Command.AddParameter("metadescription",metadescription,DbType.String);
            sp.Command.AddParameter("parentid",parentid,DbType.Int32);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("image",image,DbType.String);
            sp.Command.AddParameter("HasCateId",HasCateId,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Supplier_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Supplier_GetAll(int totalrow){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_GetAll",this.Provider);
            sp.Command.AddParameter("totalrow",totalrow,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Supplier_GetById(int id){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_GetById",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Supplier_Update(int id,string name,string link,int sort,string description,string metadescription,string HasCateId){
            StoredProcedure sp=new StoredProcedure("usp_Supplier_Update",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            sp.Command.AddParameter("name",name,DbType.String);
            sp.Command.AddParameter("link",link,DbType.AnsiString);
            sp.Command.AddParameter("sort",sort,DbType.Int32);
            sp.Command.AddParameter("description",description,DbType.String);
            sp.Command.AddParameter("metadescription",metadescription,DbType.String);
            sp.Command.AddParameter("HasCateId",HasCateId,DbType.AnsiString);
            return sp;
        }
        public StoredProcedure usp_Support_Add(string Skype,string Yahoo,string Name,string Phone){
            StoredProcedure sp=new StoredProcedure("usp_Support_Add",this.Provider);
            sp.Command.AddParameter("Skype",Skype,DbType.String);
            sp.Command.AddParameter("Yahoo",Yahoo,DbType.String);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Phone",Phone,DbType.String);
            return sp;
        }
        public StoredProcedure usp_Support_Delete(int Id){
            StoredProcedure sp=new StoredProcedure("usp_Support_Delete",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Support_GetById(int Id){
            StoredProcedure sp=new StoredProcedure("usp_Support_GetById",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_Support_GetList_All(){
            StoredProcedure sp=new StoredProcedure("usp_Support_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure usp_Support_Update(int Id,string Skype,string Yahoo,string Name,string Phone){
            StoredProcedure sp=new StoredProcedure("usp_Support_Update",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Skype",Skype,DbType.String);
            sp.Command.AddParameter("Yahoo",Yahoo,DbType.String);
            sp.Command.AddParameter("Name",Name,DbType.String);
            sp.Command.AddParameter("Phone",Phone,DbType.String);
            return sp;
        }
        public StoredProcedure usp_tblUser_Add(int Id,string Username,string Password,string Fullname,short Status){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Add",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Username",Username,DbType.String);
            sp.Command.AddParameter("Password",Password,DbType.String);
            sp.Command.AddParameter("Fullname",Fullname,DbType.String);
            sp.Command.AddParameter("Status",Status,DbType.Int16);
            return sp;
        }
        public StoredProcedure usp_tblUser_Delete(int id){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Delete",this.Provider);
            sp.Command.AddParameter("id",id,DbType.Int32);
            return sp;
        }
        public StoredProcedure usp_tblUser_GetList_All(){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_GetList_All",this.Provider);
            return sp;
        }
        public StoredProcedure usp_tblUser_Update(int Id,string Username,string Password,string Fullname,short Status){
            StoredProcedure sp=new StoredProcedure("usp_tblUser_Update",this.Provider);
            sp.Command.AddParameter("Id",Id,DbType.Int32);
            sp.Command.AddParameter("Username",Username,DbType.String);
            sp.Command.AddParameter("Password",Password,DbType.String);
            sp.Command.AddParameter("Fullname",Fullname,DbType.String);
            sp.Command.AddParameter("Status",Status,DbType.Int16);
            return sp;
        }
	
	}
	
}
 