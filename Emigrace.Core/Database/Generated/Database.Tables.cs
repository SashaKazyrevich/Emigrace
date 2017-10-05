using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Core.Database.Generated
{
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable ConditionIsAlwaysTrueOrFalse
		public abstract class TableEntity
		{
			internal abstract void EntitySetId(long id);

			internal abstract string EntityInsertSql { get; }
			internal abstract string EntityUpdateSql { get; }

			public abstract long Id { get; set; }
		}

		public partial class ArchivalDocumentPage : TableEntity
		{
			public long DocumentId { get; set; }
			public string PhotoNumber { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO ArchivalDocumentPages([DocumentId], [PhotoNumber]) VALUES (@DocumentId, @PhotoNumber)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE ArchivalDocumentPages SET [DocumentId] = @DocumentId, [PhotoNumber] = @PhotoNumber  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as ArchivalDocumentPage;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (DocumentId != entity.DocumentId) {
					return false;
				}
				if (PhotoNumber != entity.PhotoNumber) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ DocumentId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (PhotoNumber != null ? PhotoNumber.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class ArchivalDocument : TableEntity
		{
			public long FondId { get; set; }
			public int? InventoryNumber { get; set; }
			public int? FileNumber { get; set; }
			public int DocumentNumber { get; set; }
			public string Language { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO ArchivalDocuments([DocumentNumber], [FileNumber], [FondId], [InventoryNumber], [Language]) VALUES (@DocumentNumber, @FileNumber, @FondId, @InventoryNumber, @Language)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE ArchivalDocuments SET [DocumentNumber] = @DocumentNumber, [FileNumber] = @FileNumber, [FondId] = @FondId, [InventoryNumber] = @InventoryNumber, [Language] = @Language  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as ArchivalDocument;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (FondId != entity.FondId) {
					return false;
				}
				if (InventoryNumber != entity.InventoryNumber) {
					return false;
				}
				if (FileNumber != entity.FileNumber) {
					return false;
				}
				if (DocumentNumber != entity.DocumentNumber) {
					return false;
				}
				if (Language != entity.Language) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ FondId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (InventoryNumber != null ? InventoryNumber.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FileNumber != null ? FileNumber.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ DocumentNumber.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Language != null ? Language.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class ArchivalFond : TableEntity
		{
			public string FondNumber { get; set; }
			public string FondName { get; set; }
			public long ArchiveId { get; set; }
			public string TimeInterval { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO ArchivalFonds([ArchiveId], [FondName], [FondNumber], [TimeInterval]) VALUES (@ArchiveId, @FondName, @FondNumber, @TimeInterval)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE ArchivalFonds SET [ArchiveId] = @ArchiveId, [FondName] = @FondName, [FondNumber] = @FondNumber, [TimeInterval] = @TimeInterval  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as ArchivalFond;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (FondNumber != entity.FondNumber) {
					return false;
				}
				if (FondName != entity.FondName) {
					return false;
				}
				if (ArchiveId != entity.ArchiveId) {
					return false;
				}
				if (TimeInterval != entity.TimeInterval) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (FondNumber != null ? FondNumber.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FondName != null ? FondName.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ ArchiveId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (TimeInterval != null ? TimeInterval.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class Archive : TableEntity
		{
			public string Name { get; set; }
			public string Adress { get; set; }
			public string Country { get; set; }
			public string Phone { get; set; }
			public string WebPages { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Archives([Adress], [Country], [Name], [Phone], [WebPages]) VALUES (@Adress, @Country, @Name, @Phone, @WebPages)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Archives SET [Adress] = @Adress, [Country] = @Country, [Name] = @Name, [Phone] = @Phone, [WebPages] = @WebPages  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as Archive;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				if (Adress != entity.Adress) {
					return false;
				}
				if (Country != entity.Country) {
					return false;
				}
				if (Phone != entity.Phone) {
					return false;
				}
				if (WebPages != entity.WebPages) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Adress != null ? Adress.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Country != null ? Country.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Phone != null ? Phone.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (WebPages != null ? WebPages.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class BookPage : TableEntity
		{
			public long BookId { get; set; }
			public string PhotoNumber { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO BookPages([BookId], [PhotoNumber]) VALUES (@BookId, @PhotoNumber)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE BookPages SET [BookId] = @BookId, [PhotoNumber] = @PhotoNumber  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as BookPage;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (BookId != entity.BookId) {
					return false;
				}
				if (PhotoNumber != entity.PhotoNumber) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ BookId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (PhotoNumber != null ? PhotoNumber.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class Book : TableEntity
		{
			public string Name { get; set; }
			public string Author { get; set; }
			public string PublishingYear { get; set; }
			public string TimeInterval { get; set; }
			public string Language { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Books([Author], [Language], [Name], [PublishingYear], [TimeInterval]) VALUES (@Author, @Language, @Name, @PublishingYear, @TimeInterval)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Books SET [Author] = @Author, [Language] = @Language, [Name] = @Name, [PublishingYear] = @PublishingYear, [TimeInterval] = @TimeInterval  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as Book;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				if (Author != entity.Author) {
					return false;
				}
				if (PublishingYear != entity.PublishingYear) {
					return false;
				}
				if (TimeInterval != entity.TimeInterval) {
					return false;
				}
				if (Language != entity.Language) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Author != null ? Author.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PublishingYear != null ? PublishingYear.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (TimeInterval != null ? TimeInterval.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Language != null ? Language.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class City : TableEntity
		{
			public string Name { get; set; }
			public long CountyId { get; set; }
			public bool OldName { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Cities([CountyId], [Name], [OldName]) VALUES (@CountyId, @Name, @OldName)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Cities SET [CountyId] = @CountyId, [Name] = @Name, [OldName] = @OldName  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as City;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				if (CountyId != entity.CountyId) {
					return false;
				}
				if (OldName != entity.OldName) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ CountyId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ OldName.GetHashCode();
					return hashCode;
				}
			}
		}
		
		public partial class Connection : TableEntity
		{
			public long PlaceId { get; set; }
			public long SynonymPlaceId { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Connections([PlaceId], [SynonymPlaceId]) VALUES (@PlaceId, @SynonymPlaceId)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Connections SET [PlaceId] = @PlaceId, [SynonymPlaceId] = @SynonymPlaceId  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as Connection;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (PlaceId != entity.PlaceId) {
					return false;
				}
				if (SynonymPlaceId != entity.SynonymPlaceId) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ PlaceId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ SynonymPlaceId.GetHashCode();
					return hashCode;
				}
			}
		}
		
		public partial class County : TableEntity
		{
			public string Name { get; set; }
			public long StateId { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Counties([Name], [StateId]) VALUES (@Name, @StateId)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Counties SET [Name] = @Name, [StateId] = @StateId  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as County;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				if (StateId != entity.StateId) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ StateId.GetHashCode();
					return hashCode;
				}
			}
		}
		
		public partial class Country : TableEntity
		{
			public string Name { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Countries([Name]) VALUES (@Name)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Countries SET [Name] = @Name  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as Country;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class HumanSourse : TableEntity
		{
			public string AuthorName { get; set; }
			public string AuthorFamilyName { get; set; }
			public DateTime? DateOfBirth { get; set; }
			public string PlaceOfBirth { get; set; }
			public DateTime? SharingDate { get; set; }
			public string TimeInterval { get; set; }
			public string TypeOfInformation { get; set; }
			public string Language { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO HumanSourses([AuthorFamilyName], [AuthorName], [DateOfBirth], [Language], [PlaceOfBirth], [SharingDate], [TimeInterval], [TypeOfInformation]) VALUES (@AuthorFamilyName, @AuthorName, @DateOfBirth, @Language, @PlaceOfBirth, @SharingDate, @TimeInterval, @TypeOfInformation)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE HumanSourses SET [AuthorFamilyName] = @AuthorFamilyName, [AuthorName] = @AuthorName, [DateOfBirth] = @DateOfBirth, [Language] = @Language, [PlaceOfBirth] = @PlaceOfBirth, [SharingDate] = @SharingDate, [TimeInterval] = @TimeInterval, [TypeOfInformation] = @TypeOfInformation  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as HumanSourse;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (AuthorName != entity.AuthorName) {
					return false;
				}
				if (AuthorFamilyName != entity.AuthorFamilyName) {
					return false;
				}
				if (DateOfBirth != entity.DateOfBirth) {
					return false;
				}
				if (PlaceOfBirth != entity.PlaceOfBirth) {
					return false;
				}
				if (SharingDate != entity.SharingDate) {
					return false;
				}
				if (TimeInterval != entity.TimeInterval) {
					return false;
				}
				if (TypeOfInformation != entity.TypeOfInformation) {
					return false;
				}
				if (Language != entity.Language) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (AuthorName != null ? AuthorName.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (AuthorFamilyName != null ? AuthorFamilyName.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (DateOfBirth != null ? DateOfBirth.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PlaceOfBirth != null ? PlaceOfBirth.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (SharingDate != null ? SharingDate.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (TimeInterval != null ? TimeInterval.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (TypeOfInformation != null ? TypeOfInformation.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Language != null ? Language.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class Person : TableEntity
		{
			public long SourceTypeID { get; set; }
			public long SourceId { get; set; }
			public string Name_Latin { get; set; }
			public string FamilyName_Latin { get; set; }
			public string Name_Cyrillic { get; set; }
			public string FamilyName_Cyrillic { get; set; }
			public string Sex { get; set; }
			public string FatherName { get; set; }
			public DateTime? DateOfBirth { get; set; }
			public string Citizenship { get; set; }
			public long? PlaceOfBirthId { get; set; }
			public long? PlaceOfEmigrationId { get; set; }
			public long? PlaceOfLivingId { get; set; }
			public long? FatherId { get; set; }
			public long? MotherId { get; set; }
			public string MaritalStatus { get; set; }
			public long? PartnerId { get; set; }
			public string Profession { get; set; }
			public string Notice { get; set; }
			public string PhotoNumber { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO Persons([Citizenship], [DateOfBirth], [FamilyName_Cyrillic], [FamilyName_Latin], [FatherId], [FatherName], [MaritalStatus], [MotherId], [Name_Cyrillic], [Name_Latin], [Notice], [PartnerId], [PhotoNumber], [PlaceOfBirthId], [PlaceOfEmigrationId], [PlaceOfLivingId], [Profession], [Sex], [SourceId], [SourceTypeID]) VALUES (@Citizenship, @DateOfBirth, @FamilyName_Cyrillic, @FamilyName_Latin, @FatherId, @FatherName, @MaritalStatus, @MotherId, @Name_Cyrillic, @Name_Latin, @Notice, @PartnerId, @PhotoNumber, @PlaceOfBirthId, @PlaceOfEmigrationId, @PlaceOfLivingId, @Profession, @Sex, @SourceId, @SourceTypeID)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE Persons SET [Citizenship] = @Citizenship, [DateOfBirth] = @DateOfBirth, [FamilyName_Cyrillic] = @FamilyName_Cyrillic, [FamilyName_Latin] = @FamilyName_Latin, [FatherId] = @FatherId, [FatherName] = @FatherName, [MaritalStatus] = @MaritalStatus, [MotherId] = @MotherId, [Name_Cyrillic] = @Name_Cyrillic, [Name_Latin] = @Name_Latin, [Notice] = @Notice, [PartnerId] = @PartnerId, [PhotoNumber] = @PhotoNumber, [PlaceOfBirthId] = @PlaceOfBirthId, [PlaceOfEmigrationId] = @PlaceOfEmigrationId, [PlaceOfLivingId] = @PlaceOfLivingId, [Profession] = @Profession, [Sex] = @Sex, [SourceId] = @SourceId, [SourceTypeID] = @SourceTypeID  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as Person;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (SourceTypeID != entity.SourceTypeID) {
					return false;
				}
				if (SourceId != entity.SourceId) {
					return false;
				}
				if (Name_Latin != entity.Name_Latin) {
					return false;
				}
				if (FamilyName_Latin != entity.FamilyName_Latin) {
					return false;
				}
				if (Name_Cyrillic != entity.Name_Cyrillic) {
					return false;
				}
				if (FamilyName_Cyrillic != entity.FamilyName_Cyrillic) {
					return false;
				}
				if (Sex != entity.Sex) {
					return false;
				}
				if (FatherName != entity.FatherName) {
					return false;
				}
				if (DateOfBirth != entity.DateOfBirth) {
					return false;
				}
				if (Citizenship != entity.Citizenship) {
					return false;
				}
				if (PlaceOfBirthId != entity.PlaceOfBirthId) {
					return false;
				}
				if (PlaceOfEmigrationId != entity.PlaceOfEmigrationId) {
					return false;
				}
				if (PlaceOfLivingId != entity.PlaceOfLivingId) {
					return false;
				}
				if (FatherId != entity.FatherId) {
					return false;
				}
				if (MotherId != entity.MotherId) {
					return false;
				}
				if (MaritalStatus != entity.MaritalStatus) {
					return false;
				}
				if (PartnerId != entity.PartnerId) {
					return false;
				}
				if (Profession != entity.Profession) {
					return false;
				}
				if (Notice != entity.Notice) {
					return false;
				}
				if (PhotoNumber != entity.PhotoNumber) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ SourceTypeID.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ SourceId.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name_Latin != null ? Name_Latin.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FamilyName_Latin != null ? FamilyName_Latin.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Name_Cyrillic != null ? Name_Cyrillic.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FamilyName_Cyrillic != null ? FamilyName_Cyrillic.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Sex != null ? Sex.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FatherName != null ? FatherName.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (DateOfBirth != null ? DateOfBirth.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Citizenship != null ? Citizenship.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PlaceOfBirthId != null ? PlaceOfBirthId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PlaceOfEmigrationId != null ? PlaceOfEmigrationId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PlaceOfLivingId != null ? PlaceOfLivingId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (FatherId != null ? FatherId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (MotherId != null ? MotherId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (MaritalStatus != null ? MaritalStatus.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PartnerId != null ? PartnerId.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Profession != null ? Profession.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Notice != null ? Notice.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (PhotoNumber != null ? PhotoNumber.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class SourceType : TableEntity
		{
			public string Name { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO SourceTypes([Name]) VALUES (@Name)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE SourceTypes SET [Name] = @Name  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as SourceType;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
		public partial class State : TableEntity
		{
			public string Name { get; set; }
			public long CountryId { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO States([CountryId], [Name]) VALUES (@CountryId, @Name)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE States SET [CountryId] = @CountryId, [Name] = @Name  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as State;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (Name != entity.Name) {
					return false;
				}
				if (CountryId != entity.CountryId) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (Name != null ? Name.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ CountryId.GetHashCode();
					return hashCode;
				}
			}
		}
		
		public partial class WebPage : TableEntity
		{
			public string _WebPage { get; set; }
			public string ExactLink { get; set; }
			public string TimeInterval { get; set; }
			public string Language { get; set; }
			public override long Id { get; set; }

			internal override void EntitySetId(long id) {  Id = id; }
			internal override string EntityInsertSql { get { return "INSERT INTO WebPages([ExactLink], [Language], [TimeInterval], [WebPage]) VALUES (@ExactLink, @Language, @TimeInterval, @WebPage)";} }
			internal override string EntityUpdateSql {  get { return "UPDATE WebPages SET [ExactLink] = @ExactLink, [Language] = @Language, [TimeInterval] = @TimeInterval, [WebPage] = @WebPage  WHERE [Id] = @Id"; } }

			public override bool Equals(object other)
			{
				if (ReferenceEquals(this, other)) {
					return true;
				}

				var entity = other as WebPage;
				if (entity == null) {
					return false;
				}

				if (Id != entity.Id) {
					return false;
				}
				if (_WebPage != entity._WebPage) {
					return false;
				}
				if (ExactLink != entity.ExactLink) {
					return false;
				}
				if (TimeInterval != entity.TimeInterval) {
					return false;
				}
				if (Language != entity.Language) {
					return false;
				}
				return true;
			}

			public override int GetHashCode()
			{
				unchecked {
					const int randomPrime = 397;
					int hashCode = Id.GetHashCode();
					hashCode = (hashCode*randomPrime) ^ (_WebPage != null ? _WebPage.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (ExactLink != null ? ExactLink.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (TimeInterval != null ? TimeInterval.GetHashCode() : 0);
					hashCode = (hashCode*randomPrime) ^ (Language != null ? Language.GetHashCode() : 0);
					return hashCode;
				}
			}
		}
		
// ReSharper restore ConditionIsAlwaysTrueOrFalse
// ReSharper restore PartialTypeWithSinglePart
// ReSharper restore InconsistentNaming
}

