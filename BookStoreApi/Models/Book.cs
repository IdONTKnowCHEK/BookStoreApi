using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BookStoreApi.Models;

public class Book
{
    // 用來指定 Id 為唯一屬性
    // 用來辨識每一筆資料
    // 處理string轉為ObjectId的結構
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    // 用來自訂義屬性名稱為 BookName 而不是 MongoDB裡的 Name 屬性名稱
    // BsonElement() 用來告訴程式資料庫的名稱是 Name
    [BsonElement("Name")]
    // JsonPropertyName() 使用 CLR 序列化屬性名稱
    [JsonPropertyName("Name")]
    public string BookName { get; set; } = null!;

    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public string Author { get; set; } = null!;
}