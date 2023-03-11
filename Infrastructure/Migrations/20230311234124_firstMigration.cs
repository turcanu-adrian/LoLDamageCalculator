using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChampionStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Health = table.Column<double>(type: "float", nullable: false),
                    HealthRegen = table.Column<double>(type: "float", nullable: false),
                    Armor = table.Column<double>(type: "float", nullable: false),
                    MagicResist = table.Column<double>(type: "float", nullable: false),
                    MovementSpeed = table.Column<double>(type: "float", nullable: false),
                    Mana = table.Column<double>(type: "float", nullable: false),
                    ManaRegen = table.Column<double>(type: "float", nullable: false),
                    AttackDamage = table.Column<double>(type: "float", nullable: false),
                    CritDamage = table.Column<double>(type: "float", nullable: false),
                    AttackSpeed = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionStatVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base = table.Column<double>(type: "float", nullable: false),
                    Bonus = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Missing = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionStatVariants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityScalings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthId = table.Column<int>(type: "int", nullable: false),
                    AttackDamageId = table.Column<int>(type: "int", nullable: false),
                    AbilityPowerId = table.Column<int>(type: "int", nullable: false),
                    AttackSpeedId = table.Column<int>(type: "int", nullable: false),
                    CriticalStrikeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScalings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityScalings_ChampionStatVariants_AbilityPowerId",
                        column: x => x.AbilityPowerId,
                        principalTable: "ChampionStatVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityScalings_ChampionStatVariants_AttackDamageId",
                        column: x => x.AttackDamageId,
                        principalTable: "ChampionStatVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityScalings_ChampionStatVariants_AttackSpeedId",
                        column: x => x.AttackSpeedId,
                        principalTable: "ChampionStatVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityScalings_ChampionStatVariants_CriticalStrikeId",
                        column: x => x.CriticalStrikeId,
                        principalTable: "ChampionStatVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityScalings_ChampionStatVariants_HealthId",
                        column: x => x.HealthId,
                        principalTable: "ChampionStatVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<double>(type: "float", nullable: false),
                    DamageType = table.Column<int>(type: "int", nullable: false),
                    Cooldown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppliesOnHits = table.Column<bool>(type: "bit", nullable: false),
                    OnHitScaling = table.Column<bool>(type: "bit", nullable: false),
                    DamageScalingsId = table.Column<int>(type: "int", nullable: false),
                    HealScalingsId = table.Column<int>(type: "int", nullable: false),
                    ShieldScalingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ability_AbilityScalings_DamageScalingsId",
                        column: x => x.DamageScalingsId,
                        principalTable: "AbilityScalings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ability_AbilityScalings_HealScalingsId",
                        column: x => x.HealScalingsId,
                        principalTable: "AbilityScalings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ability_AbilityScalings_ShieldScalingsId",
                        column: x => x.ShieldScalingsId,
                        principalTable: "AbilityScalings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChampionAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassiveId = table.Column<int>(type: "int", nullable: false),
                    QId = table.Column<int>(type: "int", nullable: false),
                    WId = table.Column<int>(type: "int", nullable: false),
                    EId = table.Column<int>(type: "int", nullable: false),
                    RId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChampionAbilities_Ability_EId",
                        column: x => x.EId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionAbilities_Ability_PassiveId",
                        column: x => x.PassiveId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionAbilities_Ability_QId",
                        column: x => x.QId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionAbilities_Ability_RId",
                        column: x => x.RId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionAbilities_Ability_WId",
                        column: x => x.WId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampionStatsBaseId = table.Column<int>(type: "int", nullable: false),
                    ChampionStatsGrowthId = table.Column<int>(type: "int", nullable: false),
                    ChampionAbilitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionAbilities_ChampionAbilitiesId",
                        column: x => x.ChampionAbilitiesId,
                        principalTable: "ChampionAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionStats_ChampionStatsBaseId",
                        column: x => x.ChampionStatsBaseId,
                        principalTable: "ChampionStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_ChampionStats_ChampionStatsGrowthId",
                        column: x => x.ChampionStatsGrowthId,
                        principalTable: "ChampionStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_DamageScalingsId",
                table: "Ability",
                column: "DamageScalingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_HealScalingsId",
                table: "Ability",
                column: "HealScalingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_ShieldScalingsId",
                table: "Ability",
                column: "ShieldScalingsId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScalings_AbilityPowerId",
                table: "AbilityScalings",
                column: "AbilityPowerId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScalings_AttackDamageId",
                table: "AbilityScalings",
                column: "AttackDamageId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScalings_AttackSpeedId",
                table: "AbilityScalings",
                column: "AttackSpeedId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScalings_CriticalStrikeId",
                table: "AbilityScalings",
                column: "CriticalStrikeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScalings_HealthId",
                table: "AbilityScalings",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionAbilities_EId",
                table: "ChampionAbilities",
                column: "EId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionAbilities_PassiveId",
                table: "ChampionAbilities",
                column: "PassiveId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionAbilities_QId",
                table: "ChampionAbilities",
                column: "QId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionAbilities_RId",
                table: "ChampionAbilities",
                column: "RId");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionAbilities_WId",
                table: "ChampionAbilities",
                column: "WId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_ChampionAbilitiesId",
                table: "Champions",
                column: "ChampionAbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_ChampionStatsBaseId",
                table: "Champions",
                column: "ChampionStatsBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_ChampionStatsGrowthId",
                table: "Champions",
                column: "ChampionStatsGrowthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "ChampionAbilities");

            migrationBuilder.DropTable(
                name: "ChampionStats");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "AbilityScalings");

            migrationBuilder.DropTable(
                name: "ChampionStatVariants");
        }
    }
}
