package com.example.ok.Service.Impl;

import com.example.ok.Entity.NhanVien;
import com.example.ok.Repo.NhanVienRepo;
import com.example.ok.Service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class NhanVienServiceImpl implements NhanVienService {
    @Autowired
    NhanVienRepo nhanVienRepo;

    @Override
    public List<NhanVien> getAll() {
        return nhanVienRepo.findAll();
    }
}
