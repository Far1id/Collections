using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            int answer;
            
            do
            {
                Console.WriteLine("============M E N U===========");
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeye imtahan elave et");
                Console.WriteLine("3. Telebenin bir imtahan balına bax");
                Console.WriteLine("4. Telebenin bütün imtahanlarını göster");
                Console.WriteLine("5. Telebenin imtahan ortalamasını göster");
                Console.WriteLine("6. Telebeden imtahan sil");
                Console.WriteLine("0. Proqramı bitir\n\n");
                Console.WriteLine("Secim edin: ");
                answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        bool check = false;
                        Console.WriteLine("Telebenin fullname ni daxil edin: ");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Telebenin No deyerini daxil edin : (Diqqet!!! Eyni no lu telebe ola bilmez!)");
                        int no = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in Students)
                        {
                            if (item.No == no)
                            {
                                check = true;
                            }
                        }
                        if (!check)
                        {
                            Student student = new Student();
                            student.No = no;
                            student.FullName = fullname;
                            Students.Add(student);
                        }
                        else
                            Console.WriteLine("eyni no lu telebe yaradila bilmez.");
                        break;
                    case 2:
                        Console.WriteLine("Telebenin no sunu daxil edin: ");
                        int no2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        string examname = Console.ReadLine();
                        Console.WriteLine("Imtahan pointini daxil edin: ");
                        double point1 = Convert.ToDouble(Console.ReadLine());
                        Students[no2].AddExam(examname, point1);
                        break;
                    case 3:
                        Console.WriteLine("Telebenin nosunu daxil edin: ");
                        int no3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        string examname2 = Console.ReadLine();
                        Console.WriteLine(Students[no3].GetExamResult(examname2)); 
                        break;
                    case 4:
                        Console.WriteLine("Telebenin no sunu daxil edin: ");
                        int no4 = Convert.ToInt32(Console.ReadLine());
                        Students[no4].GetInfo();
                        break;
                    case 5:
                        Console.WriteLine("Telebenin no sunu daxil edin: ");
                        int no5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Students[no5].GetExamAvg());
                        break;
                    case 6:
                        Console.WriteLine("Telebenin no sunu daxil edin: ");
                        int no6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        string examname3 = Console.ReadLine();
                        Students[no6].RemoveExamByExamName(examname3);
                        break;
                    default:
                        break;
                }
            } while (answer!=0);
        }
        
    }
}
