using Lab_4.Models.Library;

namespace Lab_4
{
    // "глобальное" хранилище информации доступной во
    // время пользования программой
    public static class ApplicationData
    {
        // авторизованный пользователь
        public static Person Person { get; set; }
    }
}
