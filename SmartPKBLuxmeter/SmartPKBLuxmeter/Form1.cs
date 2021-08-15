using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPKBLuxmeter.API;
using SmartPKBLuxmeter.Models;
using Refit;

namespace SmartPKBLuxmeter
{
    public partial class Form1 : Form
    {
        public static int? curLuxes = 0;
        public static int? cur = 0;

        public List<Lightning> curLights = new List<Lightning>();
        public Room room = new Room();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            GetRoomInfo(roomsSource.SelectedIndex);
            GetLightningInfo(roomsSource.SelectedIndex);
            timer1.Start();
        }

        private async void TryGetRooms()
        {
            try
            {
                roomsSource.BindingContext = this.BindingContext;
                ILightningAPI lightningAPI = RestService.For<ILightningAPI>("http://localhost:5000/");
                //асинхронно привязываем данные из таблицы к выпадающему списку
                List<Room> rooms = await lightningAPI.GetRooms();
                foreach (Room room in rooms)
                {
                    roomsSource.Items.Add(room.Name.ToString());
                }
                roomsSource.SelectedIndex = 0;
                button1.Enabled = true;
                button3.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Клиент отказал в подключении. Проверьте настройки сервера.");
            }
        }

        private async void GetLightningInfo(int nroom)
        {
            try
            {
                curLuxes = 0;
                cur = 0;
                int lights = 0;
                int turnedLights = 0;
                int? maxOutput = 0;
                ILightningAPI lightningAPI = RestService.For<ILightningAPI>("http://localhost:5000/");
                curLights = await lightningAPI.GetLightningsByRoom(nroom);
                foreach (Lightning light in curLights)
                {
                    lights++;
                    maxOutput += light.MaxOutput;
                    if (light.Turned == true)
                    {
                        curLuxes += ((light.MaxOutput / 100) * light.Value);
                        turnedLights++;
                    }
                }
                lightCurOutput.Text = curLuxes.ToString();
                lightCount.Text = lights.ToString();
                lightAct.Text = turnedLights.ToString();
                lightOutput.Text = maxOutput.ToString();
                cur = Convert.ToInt32(((curLuxes * 0.5) / room.Area));
                if (cur >= room.Nlux && room.Nlux+100 > cur)
                    lux.ForeColor = Color.DarkGreen;
                else
                    lux.ForeColor = Color.Red;
                lux.Text = cur.ToString() + " люксов";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

}

        private async void GetRoomInfo(int id)
        {
            try
            {
                ILightningAPI lightningAPI = RestService.For<ILightningAPI>("http://localhost:5000/");
                room = await lightningAPI.GetRoomById(id);
                surfArea.Text = room.Area.ToString();
                normalLux.Text = room.Nlux.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TryGetRooms();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRoomInfo(roomsSource.SelectedIndex);
            GetLightningInfo(roomsSource.SelectedIndex);
        }

        private void roomsSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRoomInfo(roomsSource.SelectedIndex);
        }
    }
}
