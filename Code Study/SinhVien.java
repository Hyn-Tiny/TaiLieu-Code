import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;


public class Nguoi
{
    protected String hoTen;
    private Date ngaySinh;
    private int CMD;
        
    //ham khoi tao khobg tham so
    public Nguoi(){}
    
    //ham khoi tao nhieu tham so
    public Nguoi(String hoTen,Date ngaySinh,int CMD){
        this.hoTen=hoTen;
        this.ngaySinh=ngaySinh;
        this.CMD=CMD;
    }
    
    //ham nhap thong tin
    public void nhapThongTin(Scanner sc){
        System.out.print("nhap hoTen:");
        hoTen=sc.nextLine();
        sc.nextLine();
        
        System.out.print("nhap ngay sinh:");
        String strDate=sc.nextLine();
        ngaySinh=strToDate(strDate);
        sc.nextLine();
        
        System.out.print("nhap lop:");
        CMD=sc.nextInt();
        sc.nextLine();
    }
    
    public Date strToDate(String strDate){
      Date dt=null;
      SimpleDateFormat sdf=new SimpleDateFormat("dd-MM-yyyy");
      try{
        dt=sdf.parse(strDate);
      }catch(ParseException e){
        System.out.print("sai ngay tháng");
      }
      return dt;
    }
    
     //ham hien thong tin
    public void hienThongTin(){
        System.out.println(" ho Ten nguoi:"+hoTen);
        System.out.println("ngay sinh:"+ngaySinh);
        System.out.println("SO CMD:"+CMD);
    }
    
}
public class HocSinh extends Nguoi{
  private String lop;
  private String khoaHoc;
  private String kyHoc;
  
  public HocSinh(){}
  public HocSinh(String hoTen,String lop,String khoaHoc ,String kyHoc){
      this.hoTen=hoTen;
      this.lop=lop;
      this.khoaHoc=khoaHoc;
      this.kyHoc=kyHoc;
  }
  
  public void nhapThongTin(Scanner sc){
      super.nhapThongTin(sc);
      System.out.println("nhap lop: ");
      lop=sc.nextLine();
      
      System.out.println("nhap khoa hpc: ");
      khoaHoc=sc.nextLine();
      
      System.out.println("nhap ky hoc: ");
      kyHoc=sc.nextLine();
      
  }
  public void hienThongTin(){
      super.hienThongTin();
      System.out.println("lop: "+lop);
      
      System.out.println("khoa hpc: "+khoaHoc);
      
      System.out.println("ky hoc: "+kyHoc);
  }
}

public class DSHS{
    private List<HocSinh>dshs;
    
    public DSHS(){
        dshs=new ArrayList<HocSinh>(19);
    }
    
    public void themDSHS(HocSinh hs){
        dshs.add(hs);
    }
    
    public void nhapDSHS(Scanner sc){
        
        HocSinh hs=new HocSinh();
        System.out.println("nhap so lương hoc dinh");
        int n=sc.nextInt();
        sc.nextLine();
        for(int i=0;i<n;i++){
            hs.nhapThongTin(sc);
            themDSHS(hs);
        }
    }
    
    public void hienDSHS(){
        for(HocSinh hs:dshs){
            hs.hienThongTin();
        }
    }
    
}
public class test{
  public static void main(String[] arg){ 
    
    Scanner sc=new Scanner(System.in);
    
    DSHS dshs=new DSHS();
    System.out.println("nhap danh sach");
    dshs.nhapDSHS(sc);
    System.out.println("hiên:");
    dshs.hienDSHS();
  }
}