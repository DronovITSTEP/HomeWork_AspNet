using DZPract13_06_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace DZPract13_06_2024.Pages
{
    public class SessionsModel : PageModel
    {
        public List<Movie> Movies { get; set; }


        public SessionsModel()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Name="�������� ���",
                    Director="������� ��������",
                    Genre="�������",
                    PreviewText="����� �������� ��� ��� �������� ���� " +
                    "� ����� ����� ������� ��� ������, " +
                    "����������� ����� ������ � ����� �����, " +
                    "�� ������ �� �������� �� ����� ��������� �������.",
                    Sessions=new List<DateTime>
                    {
						new DateTime(13,06,2024,13,00,00),
						new DateTime(13,06,2024,15,00,00),
						new DateTime(13,06,2024,17,00,00)
					}
				},
                new Movie
                {
					Name="������������",
					Director="���� �������",
					Genre="�����",
					PreviewText="����� ������������ ��������� � ������������ ����, " +
                    "���������� �� ��������� �������. ���� ����� ����� �������� ������ " +
                    "�� �������� ��������, ������ ���� ����� ������� ���������� � ����. ",
					Sessions=new List<DateTime>
					{
						new DateTime(13,06,2024,10,00,00),
						new DateTime(13,06,2024,12,00,00),
						new DateTime(13,06,2024,14,00,00)
					}
				},
                new Movie
                {
					Name="�� ������",
					Director="���� �����",
					Genre="�����",
					PreviewText="����� �� ������ ���������� � ������� 1939 ���� ����� ��� ��� ����� ������ " +
                    "������ ������� ����� � ��������� �������� �� ���������� ������. " +
                    "�� ���� ���� ������� ��������� � ����� ��������� ������������ ������� ����� " +
                    "��������� �������� ������ ������. � ������ � ������� ����� ���������� ����������� " +
                    "����������� � ����������� ���������� ������ ���������� ������ ������.",
					Sessions=new List<DateTime>
					{
						new DateTime(13,06,2024,16,00,00),
						new DateTime(13,06,2024,18,00,00),
						new DateTime(13,06,2024,20,00,00)
					}
				}

            };

        }

        public void OnGet()
        {
            ViewData["Movies"] = Movies;
        }
    }
}
