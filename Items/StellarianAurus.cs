using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StellaAurum.Items
{
    public class StellarianAurus : ModItem
    {
        public override void SetStaticDefaults()
        {
            // By default, capitalization in classnames will add spaces to the display name.
            // You can customize the display name here by uncommenting this line.
            DisplayName.SetDefault("Stellarian Aurus");
            Tooltip.SetDefault("The power of the stars rests within");
        }
        public override void SetDefaults()
        {
            Item.damage = 112;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 5;
            Item.value = 1000;
            Item.rare = ItemRarityID.Expert;
            Item.UseSound = SoundID.Roar;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.FallingStar;
            Item.shootSpeed = 10f;
            Item.noMelee = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Darkness, 120);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FallenStar, 50);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}