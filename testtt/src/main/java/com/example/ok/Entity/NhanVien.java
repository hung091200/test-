package com.example.ok.Entity;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Entity
@Table(name = "nhanvien")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class NhanVien {
    @Id
    @Column(name = "stt")
    private int stt;

    @Column(name = "hoten")
    private String hoten;

    @Column(name = "tuoi")
    private int tuoi;

    @Column(name = "sdt")
    private String sdt;

    @Column(name = "gioi_tinh")
    private String gioi_tinh;

    @Column(name = "phong_ban")
    private String phong_ban;

    @Column(name = "vi_tri")
    private String vi_tri;

}
