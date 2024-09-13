using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIhuongdoituong2018_2019
{
    class DSBENHNHAN
    {
        Dictionary<string, BENHNHAN> danhsach;          // = new Dictionary<string, BENHNHAN>();
        public DSBENHNHAN()
        {
            danhsach = new Dictionary<string, BENHNHAN>();
        }
        internal Dictionary<string, BENHNHAN> Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public void Nhap()
        {
            /*Console.WriteLine("Nhập ký tự N để tiếp tục và phím bất kỳ để kết thúc");
            char C;
            C = char.Parse(Console.ReadLine());
            while(C == 'N' || C == 'n')
            {
                BENHNHAN benhnhan = null;
                Console.WriteLine("Nhập ký tự Y cho BNBHYT và X cho BNBHXH");
                char T;
                T = char.Parse(Console.ReadLine());
                if(T == 'Y' || T == 'y')
                        {
                            benhnhan = new BNBHYT();
                            try
                            {
                                benhnhan.Nhap();
                                danhsach.Add(benhnhan.MaBenhNhan, benhnhan);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("Nhập mã bị trùng hoặc thời gian bị lỗi");
                            }
                        }
                else if(T == 'X' || T == 'x')
                {
                    benhnhan = new BNBHXH();
                    try
                    {
                        benhnhan.Nhap();
                        danhsach.Add(benhnhan.MaBenhNhan, benhnhan);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nhập mã bị trùng hoặc thời gian bị lỗi");
                    }
                }
                Console.WriteLine("\nNhập ký tự N để tiếp tục và phím bất kỳ để kết thúc");
                C = char.Parse(Console.ReadLine());
            }*/
            Danhsach.Add("XH1", new BNBHXH("XH1", "Xã hội 1", DateTime.Parse("11/11/2021"), "BHXH1"));
            Danhsach.Add("YT2", new BNBHXH("YT2", "Y tế 2", DateTime.Parse("12/12/2022"), "BHYT2"));
            Danhsach.Add("XH3", new BNBHXH("XH3", "Xã hội 3", DateTime.Parse("03/03/2023"), "BHXH3"));
            Console.WriteLine("Nhập thành công");
        }
        
        public void Xuat()
        {
            foreach(BENHNHAN bn in danhsach.Values)
            {
                bn.Xuat(); 
            }
        }
        public new void ToString()
        {
            foreach (BENHNHAN bn in danhsach.Values)
            {
               Console.WriteLine(bn.ToString());
            }
        }
        public void Tim(string bn)
        {
            int p = 0;
            BENHNHAN BNcantim = null;
            foreach (BENHNHAN benhnhan in danhsach.Values)
                if (benhnhan.MaBenhNhan == bn)
                {
                    p = 1;
                    BNcantim = benhnhan;
                    break;
                }
            if (p == 1)
            {
                Console.WriteLine("\nCó mã bệnh nhân cần tìm");
                Console.WriteLine("Thông tin bệnh nhân cần tìm");
                BNcantim.Xuat();
            }
            else Console.WriteLine("Không có mã bệnh nhân cần tìm");
        }
        public void Xoa(string bn)
        {
            int X = 0;
            foreach(BENHNHAN benhnhan in danhsach.Values)
            {
                if(benhnhan.MaBenhNhan == bn)
                {
                    X = 1;
                     Console.WriteLine("\nCó mã cần xóa");
                    danhsach.Remove(benhnhan.MaBenhNhan);
                    break;
                }
            }
            if (X == 1)
            {
                Console.WriteLine("Danh sách sau khi xóa");
                Xuat();
            }
            if (X == 0)
                Console.WriteLine("\nKhông có mã cần xóa");
        }
        public void Capnhat1(string bn)
        {
            int T = 0;
            foreach(BENHNHAN benhnhan in danhsach.Values) 
                if (benhnhan.MaBenhNhan == bn){
                    T = 1;    // Nếu ko có T = 1 thì T luôn là 0 và sẽ xuất ra dòng cảnh báo ở lệnh if(T == 0) 
                 //   benhnhan.Nhap();        ///Nếu chỉ dùng mỗi hàm Nhap() thì khi nhập có thể bị trùng mã nhưng khi xuất vẫn hiện lên 2 mã giống
                                                        //nhau vì lúc này chưa sử dụng hàm Add của danh sách                    
                    while(true)
                    try{
                        danhsach.Remove(bn); // nếu thay bn là benhnhan.Mabenhnhan thì nếu như khi nhập benhnhan.Mabenhnhan trùng mã thì try catch 
                                              //sẽ quay lại và tiếp theo là xóa 1 bản ghi nữa (vì lúc này benhnhan.Mabenhnhan là benhnhan tiếp 
                                                      //theo trong danh sách) là thành xóa 2 bản ghi => sai. Còn nếu như để bn thì sau khi xóa 
                                             // bệnh nhân có mã bn thì sẽ ko còn bệnh nhân có mã bn để xóa nữa                                                                        
                        benhnhan.Nhap();
                        //danhsach.Remove(bn);
                        danhsach.Add(benhnhan.MaBenhNhan, benhnhan); //vd: ta có 2 bệnh nhân với 2 mã là 001 và 002 và ta nhập mã bn = 002 để vào bệnh nhân có mã 002 để sửa
                        //Nếu ta dùng bn thay cho benhnhan.Mabenhnhan thì lúc này nếu như ở hàm Nhap() ta nhập mã đã có trước đó là 001,
                        //  ví dụ ở hàm Nhap(), ta nhập mã bệnh nhân = 001 thì danhsach (lúc này sẽ có 2 bệnh nhân với 2 mã đều là 001 ) 
                        //vẫn nhận vì hàm thêm danhsach.Add(bn, benhnhan) nhìn nhận bn là mã mới đã nhập ở hàm Main và quan trọng là bn = 002 khác với mã bệnh nhân = 001                               
                        // Vì vậy ở đây bắt buộc phải dùng benhnhan.Mabenhnhan (chứ ko được dùng bn) vì nếu ở hàm Nhap() ta nhập bị trùng thì sẽ đc nhập lại                                      
                        break; 
                    }
                    catch(Exception ex){
                        Console.WriteLine("Mã bị trùng, nhập lại mã");
                    }
                    break;   
                }
                if (T == 0){
                    Console.WriteLine("Mã số nhập để sửa ko có");
                }
                if (T == 1){
                    Console.WriteLine("\n Danh sách sau khi Cập nhật");
                    Xuat();
                }  
        }
        public void Capnhat2(){
            Console.WriteLine("-------Nhập vào mã bệnh nhân cần Sửa--------------");
            string maSua = Console.ReadLine().ToUpper();
            String maMoi = "";
            int timSua = 0; int luaChon;
            foreach (BENHNHAN item in Danhsach.Values)
                if (item.MaBenhNhan == maSua)
                {
                    timSua = 1;
                    do{
                        Console.WriteLine("Bạn muốn sửa thông tin gì ở nhân viên có mã {0} ? \n0: Thoát"
                            + "\n 1: Sửa Mã BN \n 2: Sửa Tên \n 3:Sửa ngày nhập viện .........", maSua);
                        luaChon = int.Parse(Console.ReadLine());
                        switch (luaChon)
                        {
                            case 0: break;
                            case 1:
                                while (true){
                                    Console.WriteLine("Nhập mã muốn sửa: "); maMoi = Console.ReadLine();
                                    if (Danhsach.ContainsKey(maMoi)){
                                        if (item.MaBenhNhan == maMoi)
                                        { Console.WriteLine("Bạn không muốn sửa mã"); break; }
                                        else Console.WriteLine("Bạn đã nhập trùng mã đã có");
                                    }else{
                                        item.MaBenhNhan = maMoi;  //DSNV1.Remove(maSua); //DSNV1.Add(maMoi, item);
                                        Console.WriteLine("Đã sửa xong mã");
                                        break;
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Nhập tên bệnh nhân muốn sửa"); string tenMoi = Console.ReadLine();
                                item.HoTen = tenMoi;
                                break;
                            case 3:
                                Console.WriteLine("Nhập ngày nhập viện muốn sửa"); DateTime ngayMoi = DateTime.Parse(Console.ReadLine());
                                item.NgayNhapVien = ngayMoi;
                                break;
                            default: Console.WriteLine("Chỉ được nhập số từ 0 đến 3 để sửa"); break;
                        }
                    } while (luaChon != 0);
                }
            if (timSua == 0) Console.WriteLine("Không có bệnh nhân này trong danh sách");
        }
        public void Them(string bn)
        {
            BENHNHAN BenhNhan = null; 
            int Th = 1;
            foreach (BENHNHAN benhnhan in danhsach.Values)
            {
                if (benhnhan.MaBenhNhan == bn)
                { Th = 0; Console.WriteLine("Mã số bệnh nhân nhập để thêm bị trùng"); break; }
                else Th = 1;
            }
            bool kiemtra = true;
            if (Th == 0)
            {               
                while (kiemtra)
                {
                    Console.WriteLine("Nhập lại mã bệnh nhân cần thêm"); string nhaplai = Console.ReadLine();
                    foreach (BENHNHAN benhnhan in danhsach.Values)
                    {
                        if (benhnhan.MaBenhNhan == nhaplai)
                        { Console.WriteLine("Mã số nhập để thêm LẠI bị trùng"); kiemtra = true; break; }
                        else { kiemtra = false; }
                    }
                }
            }
            if (Th == 1 || kiemtra == false)
            {
                Console.WriteLine("Mã cần thêm hợp lệ");
                Char G;
                do
                {
                    Console.WriteLine("Nhập ký tự Y cho BNBHYT và X cho BNBHXH, nhấn phím bất kỳ để đi tới bước tiếp theo");
                    Char C;
                    C = Char.Parse(Console.ReadLine());
                    if (C == 'Y' || C == 'y')
                    {
                        BenhNhan = new BNBHYT();
                        try
                        {
                            BenhNhan.Nhap();
                            danhsach.Add(BenhNhan.MaBenhNhan, BenhNhan);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Nhập mã bị trùng hoặc thời gian bị lỗi");
                        }
                    }
                  
                    else if (C == 'X' || C == 'x')
                    {
                        BenhNhan = new BNBHXH();
                        try
                        {
                            BenhNhan.Nhap();
                            danhsach.Add(BenhNhan.MaBenhNhan, BenhNhan);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Nhập mã bị trùng hoặc thời gian bị lỗi");
                        }
                    }
                    Console.WriteLine("\n Nhập ký tự N để tiếp tục và nhấn phím bất kỳ để kết thúc");
                    G = Char.Parse(Console.ReadLine());
                    Console.WriteLine("\n Nếu ko muốn thêm thì nhấn Enter, Nếu muốn thêm thì nhập thêm mã không được trùng với 1 trong {0} mã trước đó ", danhsach.Count);
                    string MLT = Console.ReadLine();
                    foreach (BENHNHAN benhnhan in danhsach.Values)
                    {
                        if (benhnhan.MaBenhNhan == MLT)
                        { 
                            Console.WriteLine("Mã số nhập để thêm bị trùng với 1 trong {0} mã trước đó ", danhsach.Count); 
                            //G = 'T'; 
                            break;
                        }
                    }
                    Console.WriteLine("\n Nhập ký tự N để tiếp tục và nhấn phím bất kỳ để kết thúc");
                    G = Char.Parse(Console.ReadLine());
                }
                while (G == 'N' || G == 'n');
                Console.WriteLine("\n Danh sách sau khi thêm");
                Xuat();
            }
        }
        
        public double TinhTien()
        {
            double tongtien = 0;
            foreach (BENHNHAN bn in danhsach.Values)
            {
                if (bn is BNBHXH)
                    tongtien = tongtien + ((BNBHXH)bn).TinhHoaDonVienPhi();    // Trường hợp chưa có abstract và override thì -> Đa hình, phải Dowcasting
                else if (bn is BNBHYT)                                        // vì bản chất nv lúc này vẫn là NhanVien chứ ko phải NhanVienBC
                    tongtien = tongtien + ((BNBHYT)bn).TinhHoaDonVienPhi();
            }
            return tongtien;
        }
    }
}
