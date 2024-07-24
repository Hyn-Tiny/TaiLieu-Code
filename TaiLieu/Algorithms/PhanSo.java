!import java.util.*;

 // Compiler version JDK 11.0.2

import java.util.Scanner;
public class PhanSo
{
    int tuSo;
    int mauSo;
    public PhanSo(){}
    public PhanSo(int tuSo, int mauSo){
        this.tuSo=tuSo;
        this.mauSo=mauSo;
    }
    public void nhapThongTin(Scanner sc){
        System.out.println("nhap tu so");
        tuSo=sc.nextInt();
        
        System.out.println("nhap mau so");
        mauSo=sc.nextInt();
        
    }
    
   public void hienThongTin(){
       System.out.print("Phan so "+tuSo+"/"+mauSo);
    }
    
    public PhanSo congPhanSo(PhanSo  ps2){
        int ts=tuSo*ps2.mauSo+ps2.tuSo*mauSo;
        int ms=mauSo*ps2.mauSo;
        return new PhanSo(ts,ms);
    }
    
    public PhanSo truPhanSo(PhanSo  ps2){
        int ts=tuSo*ps2.mauSo-ps2.tuSo*mauSo;
        int ms=mauSo*ps2.mauSo;
        return new PhanSo(ts,ms);
    } 
    public PhanSo nhanPhanSo(PhanSo  ps2){
        int ts=tuSo*ps2.tuSo;
        int ms=mauSo*ps2.mauSo;
        return new PhanSo(ts,ms);
    }
    
     public PhanSo chiaPhanSo(PhanSo  ps2){
        int ts=tuSo*ps2.mauSo;
        int ms=mauSo*ps2.tuSo;
        return new PhanSo(ts,ms);
    }
    
    public int UCLN(int a, int b){
        int r=a%b;
        while(r!=0){
         a=b;
         b=a;
         r=a%b;   
        }
        return b;
    }
    
}

public class test{
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        PhanSo ps=new PhanSo();
        PhanSo ps2=new PhanSo();
        PhanSo tps=new PhanSo();
        ps.nhapThongTin(sc);
        
        ps.hienThongTin();
        ps2.nhapThongTin(sc);
        tps=ps.congPhanSo(ps2);
        tps.hienThongTin();
    }
}