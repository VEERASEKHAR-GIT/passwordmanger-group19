using PasswodManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PasswodManager
{
    public class PmViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PasswordItem> _passwords;
        private  ApiService  api;


        public PmViewModel()
        {
            _passwords = new ObservableCollection<PasswordItem>();
            api = new ApiService();
            load();
        }



        public async Task load()
        {
            var res = await api.get();
            _passwords = new ObservableCollection<PasswordItem>();
            res.ForEach(_passwords.Add);
            OnPropertyChanged("passwords");
            OnPropertyChanged();
        }

        public ObservableCollection<PasswordItem> passwords
        {
            get => _passwords;
        }

        public async
        Task

addNewPassword(string app,string password)
        {
            var uid = await SecureStorage.GetAsync("uid");
            PasswordPostModel ppm = new PasswordPostModel();
            ppm.app = app;
            ppm.userId = uid;
            ppm.password = password;
            await api.SaveTodoItemAsync(ppm);
            await load();
            OnPropertyChanged("passwords");
            OnPropertyChanged();
        }


        //public async Task deletePassword(String todoId)
        //{
        //    await api.delete(todoId);
        //    await initData();
        //    OnPropertyChanged("passwords");
        //    OnPropertyChanged();
        //}

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
