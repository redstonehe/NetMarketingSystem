using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Bright.Data.Models.Mapping;

namespace Bright.Data.Models
{
    public partial class BrightContext : DbContext
    {
        static BrightContext()
        {
            Database.SetInitializer<BrightContext>(null);
        }

        public BrightContext()
            : base("Name=BrightContext")
        {
        }

        public DbSet<C_Account> C_Account { get; set; }
        public DbSet<C_AccountType> C_AccountType { get; set; }
        public DbSet<C_BankFilling> C_BankFilling { get; set; }
        public DbSet<C_Cash> C_Cash { get; set; }
        public DbSet<C_CashFlow> C_CashFlow { get; set; }
        public DbSet<C_Currency> C_Currency { get; set; }
        public DbSet<C_Recharge> C_Recharge { get; set; }
        public DbSet<C_Transfer> C_Transfer { get; set; }
        public DbSet<O_Common> O_Common { get; set; }
        public DbSet<O_Express> O_Express { get; set; }
        public DbSet<O_Order> O_Order { get; set; }
        public DbSet<O_Product> O_Product { get; set; }
        public DbSet<O_Type> O_Type { get; set; }
        public DbSet<P_Category> P_Category { get; set; }
        public DbSet<P_Package> P_Package { get; set; }
        public DbSet<P_Price> P_Price { get; set; }
        public DbSet<P_Product> P_Product { get; set; }
        public DbSet<P_TeamProduct> P_TeamProduct { get; set; }
        public DbSet<S_Score> S_Score { get; set; }
        public DbSet<S_Settle> S_Settle { get; set; }
        public DbSet<S_Track2> S_Track2 { get; set; }
        public DbSet<U_Address> U_Address { get; set; }
        public DbSet<U_AwardTitle> U_AwardTitle { get; set; }
        public DbSet<U_AwardTitleHistory> U_AwardTitleHistory { get; set; }
        public DbSet<U_Bank> U_Bank { get; set; }
        public DbSet<U_LoginLog> U_LoginLog { get; set; }
        public DbSet<U_ManagerRelation> U_ManagerRelation { get; set; }
        public DbSet<U_ParentRelation> U_ParentRelation { get; set; }
        public DbSet<U_Password> U_Password { get; set; }
        public DbSet<U_Rank> U_Rank { get; set; }
        public DbSet<U_RankHistory> U_RankHistory { get; set; }
        public DbSet<U_RankSend> U_RankSend { get; set; }
        public DbSet<U_Team> U_Team { get; set; }
        public DbSet<U_UserInfo> U_UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C_AccountMap());
            modelBuilder.Configurations.Add(new C_AccountTypeMap());
            modelBuilder.Configurations.Add(new C_BankFillingMap());
            modelBuilder.Configurations.Add(new C_CashMap());
            modelBuilder.Configurations.Add(new C_CashFlowMap());
            modelBuilder.Configurations.Add(new C_CurrencyMap());
            modelBuilder.Configurations.Add(new C_RechargeMap());
            modelBuilder.Configurations.Add(new C_TransferMap());
            modelBuilder.Configurations.Add(new O_CommonMap());
            modelBuilder.Configurations.Add(new O_ExpressMap());
            modelBuilder.Configurations.Add(new O_OrderMap());
            modelBuilder.Configurations.Add(new O_ProductMap());
            modelBuilder.Configurations.Add(new O_TypeMap());
            modelBuilder.Configurations.Add(new P_CategoryMap());
            modelBuilder.Configurations.Add(new P_PackageMap());
            modelBuilder.Configurations.Add(new P_PriceMap());
            modelBuilder.Configurations.Add(new P_ProductMap());
            modelBuilder.Configurations.Add(new P_TeamProductMap());
            modelBuilder.Configurations.Add(new S_ScoreMap());
            modelBuilder.Configurations.Add(new S_SettleMap());
            modelBuilder.Configurations.Add(new S_Track2Map());
            modelBuilder.Configurations.Add(new U_AddressMap());
            modelBuilder.Configurations.Add(new U_AwardTitleMap());
            modelBuilder.Configurations.Add(new U_AwardTitleHistoryMap());
            modelBuilder.Configurations.Add(new U_BankMap());
            modelBuilder.Configurations.Add(new U_LoginLogMap());
            modelBuilder.Configurations.Add(new U_ManagerRelationMap());
            modelBuilder.Configurations.Add(new U_ParentRelationMap());
            modelBuilder.Configurations.Add(new U_PasswordMap());
            modelBuilder.Configurations.Add(new U_RankMap());
            modelBuilder.Configurations.Add(new U_RankHistoryMap());
            modelBuilder.Configurations.Add(new U_RankSendMap());
            modelBuilder.Configurations.Add(new U_TeamMap());
            modelBuilder.Configurations.Add(new U_UserInfoMap());
        }
    }
}
