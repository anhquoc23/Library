Bước 1: Chạy file data.sql trên sql server

Bước 2: Vào project chọn app.config trên các project LibraryMangement, DTO, DAO
trong thẻ ConnectionStrings:
<connectionStrings>
  <add name="QLTVEntities" connectionString="metadata=res://*/QLTV.csdl|res://*/QLTV.ssdl|res://*/QLTV.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=QUOC;initial catalog=Library;integrated security=True;multiple active result sets=True;application name=EntityFramework;MultipleActiveResultSets=True&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
đổi tên giá trị data soruce thành tên server chứa database mới tạo
đổi giá trị initial catalog thành tên database mới tạo


Bước 3: chạy project và xem kết quả
