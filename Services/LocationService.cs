namespace Fitness_Pro_Client.Services;

public class LocationService
{
    private readonly Dictionary<string, List<string>> locations = new()
    {
        ["Cairo"] = new() { "Nasr City", "Maadi", "Heliopolis", "Shubra", "Zamalek", "New Cairo", "Downtown" },
        ["Giza"] = new() { "6th October", "Dokki", "Mohandessin", "Faisal", "Haram", "Sheikh Zayed" },
        ["Alexandria"] = new() { "Stanley", "Smouha", "Gleem", "Miami", "Sidi Gaber", "Mandara" },
        ["Qalyubia"] = new() { "Banha", "Shubra El Kheima", "Qalyub", "Khosous", "Tukh" },
        ["Sharqia"] = new() { "Zagazig", "Belbeis", "Abou Hammad", "Minya Al Qamh" },
        ["Dakahlia"] = new() { "Mansoura", "Talkha", "Mit Ghamr", "Sherbin" },
        ["Beheira"] = new() { "Damanhour", "Kafr El Dawwar", "Rashid", "Edku" },
        ["Kafr El Sheikh"] = new() { "Kafr El Sheikh", "Desouk", "Bella", "Sidi Salem" },
        ["Gharbia"] = new() { "Tanta", "El Mahalla El Kubra", "Kafr El Zayat", "Zefta" },
        ["Monufia"] = new() { "Shibin El Kom", "Menouf", "Ashmoun", "Sadat City" },
        ["Fayoum"] = new() { "Fayoum", "Ibshway", "Sinnuris", "Tamiya" },
        ["Beni Suef"] = new() { "Beni Suef", "El Wasta", "Nasser", "Biba" },
        ["Minya"] = new() { "Minya", "Mallawi", "Samalut", "Maghagha" },
        ["Assiut"] = new() { "Assiut", "Manfalut", "Abnub", "Dairut" },
        ["Sohag"] = new() { "Sohag", "Tahta", "Akhmim", "Gerga" },
        ["Qena"] = new() { "Qena", "Nag Hammadi", "Qus", "Dishna" },
        ["Luxor"] = new() { "Luxor", "Armant", "Esna" },
        ["Aswan"] = new() { "Aswan", "Kom Ombo", "Edfu", "Daraw" },
        ["Red Sea"] = new() { "Hurghada", "Safaga", "El Quseir", "Marsa Alam" },
        ["South Sinai"] = new() { "Sharm El Sheikh", "Dahab", "Nuweiba", "Saint Catherine" },
        ["North Sinai"] = new() { "Arish", "Sheikh Zuweid", "Bir El Abd" },
        ["Matrouh"] = new() { "Marsa Matrouh", "El Alamein", "Siwa" },
        ["New Valley"] = new() { "Kharga", "Dakhla", "Farafra" },
        ["Ismailia"] = new() { "Ismailia", "Qantara", "Fayed" },
        ["Suez"] = new() { "Suez", "Ain Sokhna" },
        ["Port Said"] = new() { "Port Said", "Port Fouad" },
        ["Damietta"] = new() { "Damietta", "New Damietta", "Kafr Saad" }
    };

    public Task<List<string>> GetGovernoratesAsync()
    {
        return Task.FromResult(locations.Keys.ToList());
    }

    public Task<List<string>> GetCitiesAsync(string governorate)
    {
        return Task.FromResult(locations.TryGetValue(governorate, out List<string>? cities) ? cities : []);
    }
}
