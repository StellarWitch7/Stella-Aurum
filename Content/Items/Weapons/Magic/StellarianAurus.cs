using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StellaAurum.Content.Items.Weapons.Magic
{
    internal class StellarianAurus : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 54;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.knockBack = 5;
            Item.value = 1000;
            Item.mana = 4;
            Item.rare = ItemRarityID.Expert;
            Item.UseSound = SoundID.Roar;
            Item.expertOnly = true;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.MoonlordBullet;
            Item.shootSpeed = 8f;
            Item.noMelee = true;
            Item.crit = 12;
        }

        public virtual bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source,
            Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            return true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FallenStar, 50);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}