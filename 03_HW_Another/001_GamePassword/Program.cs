Console.Clear();

// � ���������� string ���� ��������� ���������, 
// �� ������ ���� ������. ������������ ��������� ����� 3 ������� 
// ������ ������ � ������� ��������� ���������.

string sicretMassage = "�� ������� �������, ������ �� ������ ��� ��� �������� :)";
string password = "1996";

bool Answer(string gess, string answer)
{
    if(gess==answer) return true;
    return false;
}

string Help(int i)
{
    if (i==1) return "���������: ��� ��� ����� ��������";
    if (i==2) return "���������: ��������� ����� ������ ��� 6";
    return String.Empty;

}

Console.WriteLine("������� � ����: ������� ������ � ������� ��������� ���������");
Console.WriteLine();
int index = 1;

while(index<=3)
{
    Console.Write($"{index} �������! ����� ������: ");
    string gessPassword =  Console.ReadLine();
    if (Answer(gessPassword, password)==true) 
    {
        Console.WriteLine(sicretMassage);
        break;
    }

    if (index==3) 
    {
        Console.WriteLine("�� �������� :( �������� ��� ���!");
        break;
    }
    

    Console.WriteLine(Help(index));
    Console.WriteLine();
    index++;
}
